﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestApp
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me._btnShowLogForm = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cloned Setup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add log msg"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '_btnShowLogForm
        '
        Me._btnShowLogForm.Location = New System.Drawing.Point(12, 101)
        Me._btnShowLogForm.Name = "_btnShowLogForm"
        Me._btnShowLogForm.Size = New System.Drawing.Size(75, 23)
        Me._btnShowLogForm.TabIndex = 2
        Me._btnShowLogForm.Text = "ShowLogFom"
        Me._btnShowLogForm.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Setup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TestApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 306)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me._btnShowLogForm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TestApp"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents _btnShowLogForm As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
