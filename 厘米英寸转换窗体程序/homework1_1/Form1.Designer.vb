﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(104, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(556, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(140, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 17)
        Label1.TabIndex = 2
        Label1.Text = "厘米"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(590, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 17)
        Label2.TabIndex = 3
        Label2.Text = "英寸"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(324, 56)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 23)
        Button1.TabIndex = 4
        Button1.Text = "厘米转英寸"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(324, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 23)
        Button2.TabIndex = 5
        Button2.Text = "英寸转厘米"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 203)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "英寸转厘米"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
