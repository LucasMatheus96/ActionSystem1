<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsultarAtivo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsultarAtivo))
        Me.Grb_Filtros = New System.Windows.Forms.GroupBox()
        Me.Btn_Consultar = New System.Windows.Forms.Button()
        Me.Lsw_ListaDeAtivos = New System.Windows.Forms.ListView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Btn_Alterar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Grb_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Filtros
        '
        Me.Grb_Filtros.Controls.Add(Me.Btn_Consultar)
        Me.Grb_Filtros.Location = New System.Drawing.Point(12, 31)
        Me.Grb_Filtros.Name = "Grb_Filtros"
        Me.Grb_Filtros.Size = New System.Drawing.Size(495, 96)
        Me.Grb_Filtros.TabIndex = 5
        Me.Grb_Filtros.TabStop = False
        Me.Grb_Filtros.Text = "Filtros"
        '
        'Btn_Consultar
        '
        Me.Btn_Consultar.Location = New System.Drawing.Point(343, 22)
        Me.Btn_Consultar.Name = "Btn_Consultar"
        Me.Btn_Consultar.Size = New System.Drawing.Size(146, 54)
        Me.Btn_Consultar.TabIndex = 10
        Me.Btn_Consultar.Text = "Consultar"
        Me.Btn_Consultar.UseVisualStyleBackColor = True
        '
        'Lsw_ListaDeAtivos
        '
        Me.Lsw_ListaDeAtivos.FullRowSelect = True
        Me.Lsw_ListaDeAtivos.GridLines = True
        Me.Lsw_ListaDeAtivos.HideSelection = False
        Me.Lsw_ListaDeAtivos.Location = New System.Drawing.Point(12, 132)
        Me.Lsw_ListaDeAtivos.Name = "Lsw_ListaDeAtivos"
        Me.Lsw_ListaDeAtivos.Size = New System.Drawing.Size(495, 317)
        Me.Lsw_ListaDeAtivos.TabIndex = 6
        Me.Lsw_ListaDeAtivos.UseCompatibleStateImageBehavior = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(383, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 54)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Location = New System.Drawing.Point(12, 467)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(146, 54)
        Me.Btn_Alterar.TabIndex = 7
        Me.Btn_Alterar.Text = "Alterar"
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Excluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frm_ConsultarAtivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 549)
        Me.Controls.Add(Me.Lsw_ListaDeAtivos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btn_Alterar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grb_Filtros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ConsultarAtivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ConsultarAtivo"
        Me.Grb_Filtros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grb_Filtros As GroupBox
    Friend WithEvents Btn_Consultar As Button
    Friend WithEvents Lsw_ListaDeAtivos As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents Btn_Alterar As Button
    Friend WithEvents Button2 As Button
End Class
