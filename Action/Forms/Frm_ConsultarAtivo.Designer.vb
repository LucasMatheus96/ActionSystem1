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
        Me.DataGridView_Acoes = New System.Windows.Forms.DataGridView()
        Me.DataGridView_FundoImobiliario = New System.Windows.Forms.DataGridView()
        Me.Grb_RendaFixa = New System.Windows.Forms.GroupBox()
        Me.Grb_Acoes = New System.Windows.Forms.GroupBox()
        Me.Grb_FundoImobiliarios = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Grb_Filtros.SuspendLayout()
        CType(Me.DataGridView_Acoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_FundoImobiliario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_RendaFixa.SuspendLayout()
        Me.Grb_Acoes.SuspendLayout()
        Me.Grb_FundoImobiliarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_Filtros
        '
        Me.Grb_Filtros.Controls.Add(Me.Btn_Consultar)
        Me.Grb_Filtros.Location = New System.Drawing.Point(12, 8)
        Me.Grb_Filtros.Name = "Grb_Filtros"
        Me.Grb_Filtros.Size = New System.Drawing.Size(495, 70)
        Me.Grb_Filtros.TabIndex = 5
        Me.Grb_Filtros.TabStop = False
        Me.Grb_Filtros.Text = "Filtros"
        '
        'Btn_Consultar
        '
        Me.Btn_Consultar.Location = New System.Drawing.Point(343, 22)
        Me.Btn_Consultar.Name = "Btn_Consultar"
        Me.Btn_Consultar.Size = New System.Drawing.Size(146, 35)
        Me.Btn_Consultar.TabIndex = 10
        Me.Btn_Consultar.Text = "Consultar"
        Me.Btn_Consultar.UseVisualStyleBackColor = True
        '
        'Lsw_ListaDeAtivos
        '
        Me.Lsw_ListaDeAtivos.FullRowSelect = True
        Me.Lsw_ListaDeAtivos.GridLines = True
        Me.Lsw_ListaDeAtivos.HideSelection = False
        Me.Lsw_ListaDeAtivos.Location = New System.Drawing.Point(6, 19)
        Me.Lsw_ListaDeAtivos.Name = "Lsw_ListaDeAtivos"
        Me.Lsw_ListaDeAtivos.Size = New System.Drawing.Size(483, 96)
        Me.Lsw_ListaDeAtivos.TabIndex = 6
        Me.Lsw_ListaDeAtivos.UseCompatibleStateImageBehavior = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(383, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 54)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Location = New System.Drawing.Point(12, 483)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(146, 54)
        Me.Btn_Alterar.TabIndex = 7
        Me.Btn_Alterar.Text = "Alterar"
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Excluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView_Acoes
        '
        Me.DataGridView_Acoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Acoes.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView_Acoes.MultiSelect = False
        Me.DataGridView_Acoes.Name = "DataGridView_Acoes"
        Me.DataGridView_Acoes.ReadOnly = True
        Me.DataGridView_Acoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Acoes.Size = New System.Drawing.Size(483, 101)
        Me.DataGridView_Acoes.TabIndex = 10
        '
        'DataGridView_FundoImobiliario
        '
        Me.DataGridView_FundoImobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_FundoImobiliario.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView_FundoImobiliario.Name = "DataGridView_FundoImobiliario"
        Me.DataGridView_FundoImobiliario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_FundoImobiliario.Size = New System.Drawing.Size(483, 91)
        Me.DataGridView_FundoImobiliario.TabIndex = 11
        Me.DataGridView_FundoImobiliario.UseWaitCursor = True
        '
        'Grb_RendaFixa
        '
        Me.Grb_RendaFixa.Controls.Add(Me.Lsw_ListaDeAtivos)
        Me.Grb_RendaFixa.Location = New System.Drawing.Point(12, 85)
        Me.Grb_RendaFixa.Name = "Grb_RendaFixa"
        Me.Grb_RendaFixa.Size = New System.Drawing.Size(495, 121)
        Me.Grb_RendaFixa.TabIndex = 12
        Me.Grb_RendaFixa.TabStop = False
        Me.Grb_RendaFixa.Text = "Titulos de rendas fixas:"
        '
        'Grb_Acoes
        '
        Me.Grb_Acoes.Controls.Add(Me.DataGridView_Acoes)
        Me.Grb_Acoes.Location = New System.Drawing.Point(12, 216)
        Me.Grb_Acoes.Name = "Grb_Acoes"
        Me.Grb_Acoes.Size = New System.Drawing.Size(495, 135)
        Me.Grb_Acoes.TabIndex = 13
        Me.Grb_Acoes.TabStop = False
        Me.Grb_Acoes.Text = "Ações:"
        '
        'Grb_FundoImobiliarios
        '
        Me.Grb_FundoImobiliarios.Controls.Add(Me.DataGridView_FundoImobiliario)
        Me.Grb_FundoImobiliarios.Location = New System.Drawing.Point(12, 357)
        Me.Grb_FundoImobiliarios.Name = "Grb_FundoImobiliarios"
        Me.Grb_FundoImobiliarios.Size = New System.Drawing.Size(495, 121)
        Me.Grb_FundoImobiliarios.TabIndex = 14
        Me.Grb_FundoImobiliarios.TabStop = False
        Me.Grb_FundoImobiliarios.Text = "Fundo Imobiliarios"
        '
        'Frm_ConsultarAtivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 549)
        Me.Controls.Add(Me.Grb_FundoImobiliarios)
        Me.Controls.Add(Me.Grb_Acoes)
        Me.Controls.Add(Me.Grb_RendaFixa)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btn_Alterar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grb_Filtros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ConsultarAtivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ConsultarAtivo"
        Me.Grb_Filtros.ResumeLayout(False)
        CType(Me.DataGridView_Acoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_FundoImobiliario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_RendaFixa.ResumeLayout(False)
        Me.Grb_Acoes.ResumeLayout(False)
        Me.Grb_FundoImobiliarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grb_Filtros As GroupBox
    Friend WithEvents Btn_Consultar As Button
    Friend WithEvents Lsw_ListaDeAtivos As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents Btn_Alterar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView_Acoes As DataGridView
    Friend WithEvents DataGridView_FundoImobiliario As DataGridView
    Friend WithEvents Grb_RendaFixa As GroupBox
    Friend WithEvents Grb_Acoes As GroupBox
    Friend WithEvents Grb_FundoImobiliarios As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
