<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radUsers = New System.Windows.Forms.RadioButton
        Me.radComputers = New System.Windows.Forms.RadioButton
        Me.radUsersAndComputers = New System.Windows.Forms.RadioButton
        Me.btnStart = New System.Windows.Forms.Button
        Me.lblDomainPath = New System.Windows.Forms.Label
        Me.txtSearchRoot = New System.Windows.Forms.TextBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.lblDomainPathExample = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'radUsers
        '
        Me.radUsers.AutoSize = True
        Me.radUsers.Location = New System.Drawing.Point(12, 95)
        Me.radUsers.Name = "radUsers"
        Me.radUsers.Size = New System.Drawing.Size(52, 17)
        Me.radUsers.TabIndex = 0
        Me.radUsers.TabStop = True
        Me.radUsers.Text = "Users"
        Me.radUsers.UseVisualStyleBackColor = True
        '
        'radComputers
        '
        Me.radComputers.AutoSize = True
        Me.radComputers.Location = New System.Drawing.Point(12, 118)
        Me.radComputers.Name = "radComputers"
        Me.radComputers.Size = New System.Drawing.Size(75, 17)
        Me.radComputers.TabIndex = 1
        Me.radComputers.TabStop = True
        Me.radComputers.Text = "Computers"
        Me.radComputers.UseVisualStyleBackColor = True
        '
        'radUsersAndComputers
        '
        Me.radUsersAndComputers.AutoSize = True
        Me.radUsersAndComputers.Location = New System.Drawing.Point(12, 141)
        Me.radUsersAndComputers.Name = "radUsersAndComputers"
        Me.radUsersAndComputers.Size = New System.Drawing.Size(126, 17)
        Me.radUsersAndComputers.TabIndex = 2
        Me.radUsersAndComputers.TabStop = True
        Me.radUsersAndComputers.Text = "Users and Computers"
        Me.radUsersAndComputers.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(344, 172)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(71, 28)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblDomainPath
        '
        Me.lblDomainPath.AutoSize = True
        Me.lblDomainPath.Location = New System.Drawing.Point(6, 9)
        Me.lblDomainPath.Name = "lblDomainPath"
        Me.lblDomainPath.Size = New System.Drawing.Size(67, 13)
        Me.lblDomainPath.TabIndex = 4
        Me.lblDomainPath.Text = "Search Root"
        '
        'txtSearchRoot
        '
        Me.txtSearchRoot.Location = New System.Drawing.Point(9, 31)
        Me.txtSearchRoot.Name = "txtSearchRoot"
        Me.txtSearchRoot.Size = New System.Drawing.Size(397, 20)
        Me.txtSearchRoot.TabIndex = 5
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(424, 210)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 414
        Me.LineShape2.Y1 = 164
        Me.LineShape2.Y2 = 164
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 414
        Me.LineShape1.Y1 = 77
        Me.LineShape1.Y2 = 77
        '
        'lblDomainPathExample
        '
        Me.lblDomainPathExample.AutoSize = True
        Me.lblDomainPathExample.Location = New System.Drawing.Point(9, 57)
        Me.lblDomainPathExample.Name = "lblDomainPathExample"
        Me.lblDomainPathExample.Size = New System.Drawing.Size(399, 13)
        Me.lblDomainPathExample.TabIndex = 7
        Me.lblDomainPathExample.Text = "Example:  LDAP://OU=DOJ Users,DC=intranet,DC=justice,DC=wa,DC=gov,DC=au"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 210)
        Me.Controls.Add(Me.lblDomainPathExample)
        Me.Controls.Add(Me.txtSearchRoot)
        Me.Controls.Add(Me.lblDomainPath)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.radUsersAndComputers)
        Me.Controls.Add(Me.radComputers)
        Me.Controls.Add(Me.radUsers)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmMain"
        Me.Text = "Last Logon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radUsers As System.Windows.Forms.RadioButton
    Friend WithEvents radComputers As System.Windows.Forms.RadioButton
    Friend WithEvents radUsersAndComputers As System.Windows.Forms.RadioButton
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblDomainPath As System.Windows.Forms.Label
    Friend WithEvents txtSearchRoot As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblDomainPathExample As System.Windows.Forms.Label

End Class
