<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_UsuariosCadastrados
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_UsuariosCadastrados))
        Me.Lsw_Verusuarios = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_AlterarUsuario = New System.Windows.Forms.Button()
        Me.Btn_ExcluirUsuario = New System.Windows.Forms.Button()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lsw_Verusuarios
        '
        Me.Lsw_Verusuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Lsw_Verusuarios.FullRowSelect = True
        Me.Lsw_Verusuarios.GridLines = True
        Me.Lsw_Verusuarios.HideSelection = False
        Me.Lsw_Verusuarios.Location = New System.Drawing.Point(26, 39)
        Me.Lsw_Verusuarios.MultiSelect = False
        Me.Lsw_Verusuarios.Name = "Lsw_Verusuarios"
        Me.Lsw_Verusuarios.Size = New System.Drawing.Size(759, 361)
        Me.Lsw_Verusuarios.TabIndex = 0
        Me.Lsw_Verusuarios.UseCompatibleStateImageBehavior = False
        Me.Lsw_Verusuarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "Codigo"
        Me.ColumnHeader.Width = 57
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        Me.ColumnHeader1.Width = 235
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Usuario"
        Me.ColumnHeader2.Width = 146
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data de Cadastro"
        Me.ColumnHeader3.Width = 136
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Permissão"
        Me.ColumnHeader4.Width = 200
        '
        'Btn_AlterarUsuario
        '
        Me.Btn_AlterarUsuario.Location = New System.Drawing.Point(530, 406)
        Me.Btn_AlterarUsuario.Name = "Btn_AlterarUsuario"
        Me.Btn_AlterarUsuario.Size = New System.Drawing.Size(88, 23)
        Me.Btn_AlterarUsuario.TabIndex = 1
        Me.Btn_AlterarUsuario.Text = "Button1"
        Me.Btn_AlterarUsuario.UseVisualStyleBackColor = True
        '
        'Btn_ExcluirUsuario
        '
        Me.Btn_ExcluirUsuario.Location = New System.Drawing.Point(627, 406)
        Me.Btn_ExcluirUsuario.Name = "Btn_ExcluirUsuario"
        Me.Btn_ExcluirUsuario.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ExcluirUsuario.TabIndex = 2
        Me.Btn_ExcluirUsuario.Text = "Button2"
        Me.Btn_ExcluirUsuario.UseVisualStyleBackColor = True
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Location = New System.Drawing.Point(710, 406)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_voltar.TabIndex = 3
        Me.Btn_voltar.Text = "Button3"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Frm_UsuariosCadastrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_ExcluirUsuario)
        Me.Controls.Add(Me.Btn_AlterarUsuario)
        Me.Controls.Add(Me.Lsw_Verusuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_UsuariosCadastrados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_UsuariosCadastrados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lsw_Verusuarios As ListView
    Friend WithEvents Btn_AlterarUsuario As Button
    Friend WithEvents Btn_ExcluirUsuario As Button
    Friend WithEvents Btn_voltar As Button
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
