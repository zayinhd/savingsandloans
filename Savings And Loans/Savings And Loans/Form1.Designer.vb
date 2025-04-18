<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        LoadingBar = New ProgressBar()
        Label4 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' LoadingBar
        ' 
        LoadingBar.Location = New Point(32, 181)
        LoadingBar.Name = "LoadingBar"
        LoadingBar.Size = New Size(373, 20)
        LoadingBar.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Teal
        Label4.Font = New Font("Segoe UI", 30F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(177, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 54)
        Label4.TabIndex = 28
        Label4.Text = "SL"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 233)
        Controls.Add(LoadingBar)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
