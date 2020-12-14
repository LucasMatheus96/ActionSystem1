<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastraFI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastraFI))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.Cmb_FundoImobiliario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_SiglaFundoImobiliario = New System.Windows.Forms.TextBox()
        Me.Lbl_SiglaFI = New System.Windows.Forms.Label()
        Me.Btn_Cadastrar = New System.Windows.Forms.Button()
        Me.Lbl_NomeAtivo = New System.Windows.Forms.Label()
        Me.Txt_NomeFundoImobiliario = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.Btn_Limpar)
        Me.GroupBox1.Controls.Add(Me.Cmb_FundoImobiliario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_SiglaFundoImobiliario)
        Me.GroupBox1.Controls.Add(Me.Lbl_SiglaFI)
        Me.GroupBox1.Controls.Add(Me.Btn_Cadastrar)
        Me.GroupBox1.Controls.Add(Me.Lbl_NomeAtivo)
        Me.GroupBox1.Controls.Add(Me.Txt_NomeFundoImobiliario)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 335)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastrando Fundo imóbiliario"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(187, 261)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(144, 29)
        Me.Btn_Cancelar.TabIndex = 8
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Location = New System.Drawing.Point(36, 261)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(131, 29)
        Me.Btn_Limpar.TabIndex = 7
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'Cmb_FundoImobiliario
        '
        Me.Cmb_FundoImobiliario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_FundoImobiliario.FormattingEnabled = True
        Me.Cmb_FundoImobiliario.Location = New System.Drawing.Point(33, 116)
        Me.Cmb_FundoImobiliario.Name = "Cmb_FundoImobiliario"
        Me.Cmb_FundoImobiliario.Size = New System.Drawing.Size(282, 21)
        Me.Cmb_FundoImobiliario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo fundo imóbiliario"
        '
        'Txt_SiglaFundoImobiliario
        '
        Me.Txt_SiglaFundoImobiliario.Location = New System.Drawing.Point(32, 165)
        Me.Txt_SiglaFundoImobiliario.Name = "Txt_SiglaFundoImobiliario"
        Me.Txt_SiglaFundoImobiliario.Size = New System.Drawing.Size(81, 20)
        Me.Txt_SiglaFundoImobiliario.TabIndex = 5
        '
        'Lbl_SiglaFI
        '
        Me.Lbl_SiglaFI.AutoSize = True
        Me.Lbl_SiglaFI.Location = New System.Drawing.Point(29, 149)
        Me.Lbl_SiglaFI.Name = "Lbl_SiglaFI"
        Me.Lbl_SiglaFI.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_SiglaFI.TabIndex = 4
        Me.Lbl_SiglaFI.Text = "Sigla"
        '
        'Btn_Cadastrar
        '
        Me.Btn_Cadastrar.Location = New System.Drawing.Point(81, 204)
        Me.Btn_Cadastrar.Name = "Btn_Cadastrar"
        Me.Btn_Cadastrar.Size = New System.Drawing.Size(178, 51)
        Me.Btn_Cadastrar.TabIndex = 6
        Me.Btn_Cadastrar.Text = "Cadastrar"
        Me.Btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'Lbl_NomeAtivo
        '
        Me.Lbl_NomeAtivo.AutoSize = True
        Me.Lbl_NomeAtivo.Location = New System.Drawing.Point(29, 45)
        Me.Lbl_NomeAtivo.Name = "Lbl_NomeAtivo"
        Me.Lbl_NomeAtivo.Size = New System.Drawing.Size(131, 13)
        Me.Lbl_NomeAtivo.TabIndex = 0
        Me.Lbl_NomeAtivo.Text = "Nome do fundo imobiliario:"
        '
        'Txt_NomeFundoImobiliario
        '
        Me.Txt_NomeFundoImobiliario.Location = New System.Drawing.Point(32, 64)
        Me.Txt_NomeFundoImobiliario.Name = "Txt_NomeFundoImobiliario"
        Me.Txt_NomeFundoImobiliario.Size = New System.Drawing.Size(279, 20)
        Me.Txt_NomeFundoImobiliario.TabIndex = 1
        '
        'Frm_CadastraFI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadastraFI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadastrarFI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Cadastrar As Button
    Friend WithEvents Lbl_NomeAtivo As Label
    Friend WithEvents Txt_NomeFundoImobiliario As TextBox
    Friend WithEvents Lbl_SiglaFI As Label
    Friend WithEvents Cmb_FundoImobiliario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_SiglaFundoImobiliario As TextBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Limpar As Button
End Class
