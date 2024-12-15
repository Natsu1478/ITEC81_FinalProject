<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillupForm
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
        lblCurrUser = New Label()
        Label1 = New Label()
        label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblCurrUser
        ' 
        lblCurrUser.AutoSize = True
        lblCurrUser.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrUser.Location = New Point(168, 48)
        lblCurrUser.Name = "lblCurrUser"
        lblCurrUser.Size = New Size(136, 54)
        lblCurrUser.TabIndex = 7
        lblCurrUser.Text = "ADMIN"
        lblCurrUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(200, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 45)
        Label1.TabIndex = 6
        Label1.Text = "Fill Up Form"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(93, 174)
        label2.Name = "label2"
        label2.Size = New Size(79, 20)
        label2.TabIndex = 8
        label2.Text = "Admin ID: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(93, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 9
        Label3.Text = "First Name: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(93, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 10
        Label4.Text = "Middle Name: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(93, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 11
        Label5.Text = "Last Name: "
        ' 
        ' FillupForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(555, 692)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(label2)
        Controls.Add(lblCurrUser)
        Controls.Add(Label1)
        Name = "FillupForm"
        Text = "FillupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCurrUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
