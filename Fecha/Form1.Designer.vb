<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.lblres = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.cmbano = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbdia.Location = New System.Drawing.Point(186, 12)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(71, 21)
        Me.cmbdia.TabIndex = 7
        Me.cmbdia.Text = "Día"
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Location = New System.Drawing.Point(9, 50)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(115, 13)
        Me.lblres.TabIndex = 8
        Me.lblres.Text = "La fecha ingresada es:"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(9, 66)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(248, 20)
        Me.txtfecha.TabIndex = 9
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(174, 103)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(93, 103)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 11
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(12, 103)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 12
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'cmbano
        '
        Me.cmbano.FormattingEnabled = True
        Me.cmbano.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbano.Location = New System.Drawing.Point(12, 12)
        Me.cmbano.Name = "cmbano"
        Me.cmbano.Size = New System.Drawing.Size(71, 21)
        Me.cmbano.TabIndex = 13
        Me.cmbano.Text = "Año"
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre"})
        Me.cmbmes.Location = New System.Drawing.Point(93, 12)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(87, 21)
        Me.cmbmes.TabIndex = 14
        Me.cmbmes.Text = "Mes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 138)
        Me.Controls.Add(Me.cmbmes)
        Me.Controls.Add(Me.cmbano)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.lblres)
        Me.Controls.Add(Me.cmbdia)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents lblres As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents cmbano As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox

End Class
