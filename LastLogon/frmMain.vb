Imports System.directoryServices
Imports System.DirectoryServices.ActiveDirectory

Public Class frmMain

    Private Sub ProcessOption(ByVal intOption As Integer)
        Dim colDCList As New Collection
        Dim srcResults As SearchResultCollection = Nothing
        Dim colResults As New Collection

        colDCList = GetDCList()

        Select Case intOption
            Case 1 ' Users
                srcResults = GetSearchResults(Me.txtSearchRoot.Text, "(&(objectCategory=user)(objectClass=person))")
            Case 2 ' Computers
                srcResults = GetSearchResults(Me.txtSearchRoot.Text, "(objectCategory=computer)")
            Case 3 ' Users and Computers
                srcResults = GetSearchResults(Me.txtSearchRoot.Text, "(|(&(objectCategory=user)(objectClass=person))(objectCategory=computer))")
        End Select

        For Each DC As String In colDCList
            GetLogonDetails(DC, srcResults, colResults)
        Next

    End Sub

    ' Returns a SearchResultCollection
    Public Function GetSearchResults(ByVal strSearchRoot As String, ByVal strFilter As String) As SearchResultCollection
        Dim entry As New DirectoryEntry(strSearchRoot)
        Dim mySearcher As New DirectorySearcher(entry)
        Dim strUserPath As String = ""
        Dim srcUsers As SearchResultCollection

        mySearcher.Filter = (strFilter)
        mySearcher.SearchScope = DirectoryServices.SearchScope.Subtree
        mySearcher.PropertiesToLoad.AddRange(New String() {"distinguishedname"})
        mySearcher.PropertiesToLoad.AddRange(New String() {"aDSPath"})
        mySearcher.SizeLimit = 20000
        mySearcher.PageSize = 20000
        srcUsers = mySearcher.FindAll()

        entry.Close()

        Return srcUsers

    End Function

    Private Sub GetLogonDetails(ByVal DCName As String, ByVal srcResults As SearchResultCollection, ByRef colPreviousResults As Collection)
        Dim strPath As String
        Dim oObject As DirectoryEntry
        Dim colResults As New Collection
        Dim datPreviousInstanceOfLastLoginDateTime As DateTime = Nothing
        Dim datCurrentInstanceOfLastLoginDateTime As DateTime = Nothing

        For Each sr As SearchResult In srcResults
            strPath = sr.Path
            oObject = sr.GetDirectoryEntry()

            datPreviousInstanceOfLastLoginDateTime = colPreviousResults.Item(oObject.Name)
            datCurrentInstanceOfLastLoginDateTime = oObject.Properties("LastLogin").Value

            If colPreviousResults.Contains(oObject.Name) Then
                If datCurrentInstanceOfLastLoginDateTime > datPreviousInstanceOfLastLoginDateTime Then
                    colPreviousResults.Remove(oObject.Username)
                    colPreviousResults.Add(datCurrentInstanceOfLastLoginDateTime, oObject.Name)
                End If
            Else
                colPreviousResults.Add(datCurrentInstanceOfLastLoginDateTime, oObject.Name)
            End If

        Next

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If radUsers.Checked Then ProcessOption(1)
        If radComputers.Checked Then ProcessOption(2)
        If radUsersAndComputers.Checked Then ProcessOption(3)


    End Sub

    Private Function GetDCList() As Collection
        Dim colDCList As New Collection
        Dim myDomain As Domain
        Dim DC As DomainController
        Dim strServerName As String

        myDomain = Domain.GetCurrentDomain

        ' Remove any existing server list
        colDCList.Clear()

        For Each DC In myDomain.DomainControllers
            strServerName = Microsoft.VisualBasic.Left(DC.Name, InStr(DC.Name, ".") - 1).ToUpper
            colDCList.Add(strServerName)
            Application.DoEvents()
        Next

        Return colDCList
    End Function

End Class
