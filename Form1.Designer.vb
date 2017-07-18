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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Permlink = New System.Windows.Forms.TextBox()
        Me.Tags = New System.Windows.Forms.TextBox()
        Me.PostBody = New System.Windows.Forms.RichTextBox()
        Me.RetrieveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Post"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(12, 51)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(27, 13)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tags"
        '
        'Permlink
        '
        Me.Permlink.Location = New System.Drawing.Point(57, 18)
        Me.Permlink.Name = "Permlink"
        Me.Permlink.Size = New System.Drawing.Size(517, 20)
        Me.Permlink.TabIndex = 3
        '
        'Tags
        '
        Me.Tags.Location = New System.Drawing.Point(57, 499)
        Me.Tags.Name = "Tags"
        Me.Tags.Size = New System.Drawing.Size(607, 20)
        Me.Tags.TabIndex = 4
        '
        'PostBody
        '
        Me.PostBody.Location = New System.Drawing.Point(15, 67)
        Me.PostBody.Name = "PostBody"
        Me.PostBody.Size = New System.Drawing.Size(649, 426)
        Me.PostBody.TabIndex = 5
        Me.PostBody.Text = ""
        '
        'RetrieveBtn
        '
        Me.RetrieveBtn.Location = New System.Drawing.Point(589, 16)
        Me.RetrieveBtn.Name = "RetrieveBtn"
        Me.RetrieveBtn.Size = New System.Drawing.Size(75, 23)
        Me.RetrieveBtn.TabIndex = 0
        Me.RetrieveBtn.Text = "Retrieve"
        Me.RetrieveBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 531)
        Me.Controls.Add(Me.RetrieveBtn)
        Me.Controls.Add(Me.PostBody)
        Me.Controls.Add(Me.Tags)
        Me.Controls.Add(Me.Permlink)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Steem Post Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Permlink As TextBox
    Friend WithEvents Tags As TextBox
    Friend WithEvents PostBody As RichTextBox
    Friend WithEvents RetrieveBtn As Button
End Class
