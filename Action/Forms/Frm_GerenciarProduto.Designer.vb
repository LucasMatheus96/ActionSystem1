<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GerenciarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciarProduto))
        Me.Grb_Filtro = New System.Windows.Forms.GroupBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Cmb_TipoAtivo = New System.Windows.Forms.ComboBox()
        Me.Txt_Busca = New System.Windows.Forms.TextBox()
        Me.Lbl_a = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Cmb_Filtro = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Grb_Produtos = New System.Windows.Forms.GroupBox()
        Me.Dgw_Ativos = New System.Windows.Forms.DataGridView()
        Me.Btn_AlterarAtivo = New System.Windows.Forms.Button()
        Me.Btn_VenderAtivo = New System.Windows.Forms.Button()
        Me.Btn_ComprarAtivo = New System.Windows.Forms.Button()
        Me.Grb_Filtro.SuspendLayout()
        Me.Grb_Produtos.SuspendLayout()
        CType(Me.Dgw_Ativos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb_Filtro
        '
        Me.Grb_Filtro.Controls.Add(Me.Btn_Buscar)
        Me.Grb_Filtro.Controls.Add(Me.Cmb_TipoAtivo)
        Me.Grb_Filtro.Controls.Add(Me.Txt_Busca)
        Me.Grb_Filtro.Controls.Add(Me.Lbl_a)
        Me.Grb_Filtro.Controls.Add(Me.DateTimePicker2)
        Me.Grb_Filtro.Controls.Add(Me.DateTimePicker1)
        Me.Grb_Filtro.Controls.Add(Me.Cmb_Filtro)
        Me.Grb_Filtro.Location = New System.Drawing.Point(12, 26)
        Me.Grb_Filtro.Name = "Grb_Filtro"
        Me.Grb_Filtro.Size = New System.Drawing.Size(737, 81)
        Me.Grb_Filtro.TabIndex = 0
        Me.Grb_Filtro.TabStop = False
        Me.Grb_Filtro.Text = "Filtro"
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Location = New System.Drawing.Point(15, 44)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(716, 31)
        Me.Btn_Buscar.TabIndex = 5
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Cmb_TipoAtivo
        '
        Me.Cmb_TipoAtivo.FormattingEnabled = True
        Me.Cmb_TipoAtivo.Location = New System.Drawing.Point(178, 19)
        Me.Cmb_TipoAtivo.Name = "Cmb_TipoAtivo"
        Me.Cmb_TipoAtivo.Size = New System.Drawing.Size(0, 21)
        Me.Cmb_TipoAtivo.TabIndex = 5
        '
        'Txt_Busca
        '
        Me.Txt_Busca.Location = New System.Drawing.Point(178, 21)
        Me.Txt_Busca.Name = "Txt_Busca"
        Me.Txt_Busca.Size = New System.Drawing.Size(0, 20)
        Me.Txt_Busca.TabIndex = 4
        '
        'Lbl_a
        '
        Me.Lbl_a.AutoSize = True
        Me.Lbl_a.Location = New System.Drawing.Point(303, 24)
        Me.Lbl_a.Name = "Lbl_a"
        Me.Lbl_a.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_a.TabIndex = 3
        Me.Lbl_a.Text = "a"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(327, 21)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(195, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2020, 12, 12, 0, 0, 0, 0)
        '
        'Cmb_Filtro
        '
        Me.Cmb_Filtro.FormattingEnabled = True
        Me.Cmb_Filtro.Location = New System.Drawing.Point(15, 19)
        Me.Cmb_Filtro.Name = "Cmb_Filtro"
        Me.Cmb_Filtro.Size = New System.Drawing.Size(148, 21)
        Me.Cmb_Filtro.TabIndex = 0
        '
        'Grb_Produtos
        '
        Me.Grb_Produtos.Controls.Add(Me.Dgw_Ativos)
        Me.Grb_Produtos.Location = New System.Drawing.Point(12, 124)
        Me.Grb_Produtos.Name = "Grb_Produtos"
        Me.Grb_Produtos.Size = New System.Drawing.Size(750, 314)
        Me.Grb_Produtos.TabIndex = 1
        Me.Grb_Produtos.TabStop = False
        Me.Grb_Produtos.Text = "Produtos"
        '
        'Dgw_Ativos
        '
        Me.Dgw_Ativos.AllowUserToAddRows = False
        Me.Dgw_Ativos.AllowUserToDeleteRows = False
        Me.Dgw_Ativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgw_Ativos.Location = New System.Drawing.Point(15, 33)
        Me.Dgw_Ativos.Name = "Dgw_Ativos"
        Me.Dgw_Ativos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgw_Ativos.Size = New System.Drawing.Size(722, 264)
        Me.Dgw_Ativos.TabIndex = 0
        '
        'Btn_AlterarAtivo
        '
        Me.Btn_AlterarAtivo.Location = New System.Drawing.Point(38, 444)
        Me.Btn_AlterarAtivo.Name = "Btn_AlterarAtivo"
        Me.Btn_AlterarAtivo.Size = New System.Drawing.Size(218, 31)
        Me.Btn_AlterarAtivo.TabIndex = 2
        Me.Btn_AlterarAtivo.Text = "Alterar Ativo"
        Me.Btn_AlterarAtivo.UseVisualStyleBackColor = True
        '
        'Btn_VenderAtivo
        '
        Me.Btn_VenderAtivo.Location = New System.Drawing.Point(292, 444)
        Me.Btn_VenderAtivo.Name = "Btn_VenderAtivo"
        Me.Btn_VenderAtivo.Size = New System.Drawing.Size(218, 31)
        Me.Btn_VenderAtivo.TabIndex = 3
        Me.Btn_VenderAtivo.Text = "Vender Ativos"
        Me.Btn_VenderAtivo.UseVisualStyleBackColor = True
        '
        'Btn_ComprarAtivo
        '
        Me.Btn_ComprarAtivo.Location = New System.Drawing.Point(531, 444)
        Me.Btn_ComprarAtivo.Name = "Btn_ComprarAtivo"
        Me.Btn_ComprarAtivo.Size = New System.Drawing.Size(218, 31)
        Me.Btn_ComprarAtivo.TabIndex = 4
        Me.Btn_ComprarAtivo.Text = "Comprar Ativos"
        Me.Btn_ComprarAtivo.UseVisualStyleBackColor = True
        '
        'Frm_GerenciarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 487)
        Me.Controls.Add(Me.Btn_ComprarAtivo)
        Me.Controls.Add(Me.Btn_VenderAtivo)
        Me.Controls.Add(Me.Btn_AlterarAtivo)
        Me.Controls.Add(Me.Grb_Produtos)
        Me.Controls.Add(Me.Grb_Filtro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_GerenciarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_GerenciarProduto"
        Me.Grb_Filtro.ResumeLayout(False)
        Me.Grb_Filtro.PerformLayout()
        Me.Grb_Produtos.ResumeLayout(False)
        CType(Me.Dgw_Ativos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grb_Filtro As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Grb_Produtos As GroupBox
    Friend WithEvents Dgw_Ativos As DataGridView
    Friend WithEvents Btn_AlterarAtivo As Button
    Friend WithEvents Btn_VenderAtivo As Button
    Friend WithEvents Btn_ComprarAtivo As Button
    Friend WithEvents Cmb_Filtro As ComboBox
    Friend WithEvents Txt_Busca As TextBox
    Friend WithEvents Lbl_a As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Cmb_TipoAtivo As ComboBox
    Friend WithEvents Btn_Buscar As Button
End Class
