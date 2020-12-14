<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tsl_UsuarioLogado = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarCarteiraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCarteiraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestimentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarAtivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAtivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfetuarNovoAcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl_Top = New System.Windows.Forms.Panel()
        Me.Btn_ConsultarCarteira = New System.Windows.Forms.Button()
        Me.Btn_ConsultarAtivos = New System.Windows.Forms.Button()
        Me.Btn_Cadastraativos = New System.Windows.Forms.Button()
        Me.Btn_GerenciarInvestimento = New System.Windows.Forms.Button()
        Me.Btn_AdicionarInvestimento = New System.Windows.Forms.Button()
        Me.Btn_CadastrarCarteira = New System.Windows.Forms.Button()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Pnl_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsl_UsuarioLogado})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 539)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1102, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tsl_UsuarioLogado
        '
        Me.Tsl_UsuarioLogado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Tsl_UsuarioLogado.Name = "Tsl_UsuarioLogado"
        Me.Tsl_UsuarioLogado.Size = New System.Drawing.Size(87, 22)
        Me.Tsl_UsuarioLogado.Text = "ToolStripLabel1"
        Me.Tsl_UsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Tsl_UsuarioLogado.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.InvestimentosToolStripMenuItem, Me.AtivosToolStripMenuItem, Me.UtilitariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1102, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarCarteiraToolStripMenuItem, Me.ConsultarCarteiraToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Image = CType(resources.GetObject("CadastroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CadastroToolStripMenuItem.Text = "Carteira"
        '
        'CadastrarCarteiraToolStripMenuItem
        '
        Me.CadastrarCarteiraToolStripMenuItem.Image = CType(resources.GetObject("CadastrarCarteiraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarCarteiraToolStripMenuItem.Name = "CadastrarCarteiraToolStripMenuItem"
        Me.CadastrarCarteiraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrarCarteiraToolStripMenuItem.Text = "Cadastrar Carteira "
        '
        'ConsultarCarteiraToolStripMenuItem
        '
        Me.ConsultarCarteiraToolStripMenuItem.Image = CType(resources.GetObject("ConsultarCarteiraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarCarteiraToolStripMenuItem.Name = "ConsultarCarteiraToolStripMenuItem"
        Me.ConsultarCarteiraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarCarteiraToolStripMenuItem.Text = "Consultar Carteira"
        '
        'InvestimentosToolStripMenuItem
        '
        Me.InvestimentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.GerenciarToolStripMenuItem})
        Me.InvestimentosToolStripMenuItem.Image = CType(resources.GetObject("InvestimentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InvestimentosToolStripMenuItem.Name = "InvestimentosToolStripMenuItem"
        Me.InvestimentosToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.InvestimentosToolStripMenuItem.Text = "Investimentos"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Image = CType(resources.GetObject("AdicionarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar"
        '
        'GerenciarToolStripMenuItem
        '
        Me.GerenciarToolStripMenuItem.Image = CType(resources.GetObject("GerenciarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciarToolStripMenuItem.Name = "GerenciarToolStripMenuItem"
        Me.GerenciarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GerenciarToolStripMenuItem.Text = "Gerenciar"
        '
        'AtivosToolStripMenuItem
        '
        Me.AtivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarAtivosToolStripMenuItem, Me.ConsultarAtivosToolStripMenuItem})
        Me.AtivosToolStripMenuItem.Image = CType(resources.GetObject("AtivosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AtivosToolStripMenuItem.Name = "AtivosToolStripMenuItem"
        Me.AtivosToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.AtivosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AtivosToolStripMenuItem.Text = "Ativos"
        '
        'CadastrarAtivosToolStripMenuItem
        '
        Me.CadastrarAtivosToolStripMenuItem.Image = CType(resources.GetObject("CadastrarAtivosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarAtivosToolStripMenuItem.Name = "CadastrarAtivosToolStripMenuItem"
        Me.CadastrarAtivosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrarAtivosToolStripMenuItem.Text = "Cadastrar Ativos"
        '
        'ConsultarAtivosToolStripMenuItem
        '
        Me.ConsultarAtivosToolStripMenuItem.Image = CType(resources.GetObject("ConsultarAtivosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarAtivosToolStripMenuItem.Name = "ConsultarAtivosToolStripMenuItem"
        Me.ConsultarAtivosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarAtivosToolStripMenuItem.Text = "Consultar Ativos"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EfetuarNovoAcessoToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Image = CType(resources.GetObject("UtilitariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'EfetuarNovoAcessoToolStripMenuItem
        '
        Me.EfetuarNovoAcessoToolStripMenuItem.Name = "EfetuarNovoAcessoToolStripMenuItem"
        Me.EfetuarNovoAcessoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EfetuarNovoAcessoToolStripMenuItem.Text = "Efetuar Novo acesso "
        '
        'Pnl_Top
        '
        Me.Pnl_Top.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_Top.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Pnl_Top.Controls.Add(Me.Btn_ConsultarCarteira)
        Me.Pnl_Top.Controls.Add(Me.Btn_ConsultarAtivos)
        Me.Pnl_Top.Controls.Add(Me.Btn_Cadastraativos)
        Me.Pnl_Top.Controls.Add(Me.Btn_GerenciarInvestimento)
        Me.Pnl_Top.Controls.Add(Me.Btn_AdicionarInvestimento)
        Me.Pnl_Top.Controls.Add(Me.Btn_CadastrarCarteira)
        Me.Pnl_Top.Location = New System.Drawing.Point(0, 24)
        Me.Pnl_Top.Name = "Pnl_Top"
        Me.Pnl_Top.Size = New System.Drawing.Size(1102, 75)
        Me.Pnl_Top.TabIndex = 3
        '
        'Btn_ConsultarCarteira
        '
        Me.Btn_ConsultarCarteira.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_ConsultarCarteira.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ConsultarCarteira.FlatAppearance.BorderSize = 0
        Me.Btn_ConsultarCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ConsultarCarteira.Image = CType(resources.GetObject("Btn_ConsultarCarteira.Image"), System.Drawing.Image)
        Me.Btn_ConsultarCarteira.Location = New System.Drawing.Point(104, 6)
        Me.Btn_ConsultarCarteira.Name = "Btn_ConsultarCarteira"
        Me.Btn_ConsultarCarteira.Size = New System.Drawing.Size(75, 65)
        Me.Btn_ConsultarCarteira.TabIndex = 5
        Me.Btn_ConsultarCarteira.UseVisualStyleBackColor = False
        '
        'Btn_ConsultarAtivos
        '
        Me.Btn_ConsultarAtivos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_ConsultarAtivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ConsultarAtivos.FlatAppearance.BorderSize = 0
        Me.Btn_ConsultarAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ConsultarAtivos.Image = CType(resources.GetObject("Btn_ConsultarAtivos.Image"), System.Drawing.Image)
        Me.Btn_ConsultarAtivos.Location = New System.Drawing.Point(428, 6)
        Me.Btn_ConsultarAtivos.Name = "Btn_ConsultarAtivos"
        Me.Btn_ConsultarAtivos.Size = New System.Drawing.Size(75, 65)
        Me.Btn_ConsultarAtivos.TabIndex = 4
        Me.Btn_ConsultarAtivos.UseVisualStyleBackColor = False
        '
        'Btn_Cadastraativos
        '
        Me.Btn_Cadastraativos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Cadastraativos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cadastraativos.FlatAppearance.BorderSize = 0
        Me.Btn_Cadastraativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cadastraativos.Image = CType(resources.GetObject("Btn_Cadastraativos.Image"), System.Drawing.Image)
        Me.Btn_Cadastraativos.Location = New System.Drawing.Point(347, 6)
        Me.Btn_Cadastraativos.Name = "Btn_Cadastraativos"
        Me.Btn_Cadastraativos.Size = New System.Drawing.Size(75, 65)
        Me.Btn_Cadastraativos.TabIndex = 3
        Me.Btn_Cadastraativos.UseVisualStyleBackColor = False
        '
        'Btn_GerenciarInvestimento
        '
        Me.Btn_GerenciarInvestimento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_GerenciarInvestimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_GerenciarInvestimento.FlatAppearance.BorderSize = 0
        Me.Btn_GerenciarInvestimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GerenciarInvestimento.Image = CType(resources.GetObject("Btn_GerenciarInvestimento.Image"), System.Drawing.Image)
        Me.Btn_GerenciarInvestimento.Location = New System.Drawing.Point(266, 7)
        Me.Btn_GerenciarInvestimento.Name = "Btn_GerenciarInvestimento"
        Me.Btn_GerenciarInvestimento.Size = New System.Drawing.Size(75, 65)
        Me.Btn_GerenciarInvestimento.TabIndex = 2
        Me.Btn_GerenciarInvestimento.UseVisualStyleBackColor = False
        '
        'Btn_AdicionarInvestimento
        '
        Me.Btn_AdicionarInvestimento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_AdicionarInvestimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AdicionarInvestimento.FlatAppearance.BorderSize = 0
        Me.Btn_AdicionarInvestimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AdicionarInvestimento.Image = CType(resources.GetObject("Btn_AdicionarInvestimento.Image"), System.Drawing.Image)
        Me.Btn_AdicionarInvestimento.Location = New System.Drawing.Point(185, 6)
        Me.Btn_AdicionarInvestimento.Name = "Btn_AdicionarInvestimento"
        Me.Btn_AdicionarInvestimento.Size = New System.Drawing.Size(75, 65)
        Me.Btn_AdicionarInvestimento.TabIndex = 1
        Me.Btn_AdicionarInvestimento.UseVisualStyleBackColor = False
        '
        'Btn_CadastrarCarteira
        '
        Me.Btn_CadastrarCarteira.AccessibleDescription = ""
        Me.Btn_CadastrarCarteira.AccessibleName = ""
        Me.Btn_CadastrarCarteira.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Btn_CadastrarCarteira.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_CadastrarCarteira.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CadastrarCarteira.FlatAppearance.BorderSize = 0
        Me.Btn_CadastrarCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CadastrarCarteira.Image = CType(resources.GetObject("Btn_CadastrarCarteira.Image"), System.Drawing.Image)
        Me.Btn_CadastrarCarteira.Location = New System.Drawing.Point(23, 3)
        Me.Btn_CadastrarCarteira.Name = "Btn_CadastrarCarteira"
        Me.Btn_CadastrarCarteira.Size = New System.Drawing.Size(75, 65)
        Me.Btn_CadastrarCarteira.TabIndex = 0
        Me.Btn_CadastrarCarteira.UseVisualStyleBackColor = False
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuarios"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1102, 564)
        Me.Controls.Add(Me.Pnl_Top)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Pnl_Top.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Tsl_UsuarioLogado As ToolStripLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarCarteiraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCarteiraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfetuarNovoAcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarAtivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarAtivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvestimentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pnl_Top As Panel
    Friend WithEvents Btn_CadastrarCarteira As Button
    Friend WithEvents Btn_GerenciarInvestimento As Button
    Friend WithEvents Btn_AdicionarInvestimento As Button
    Friend WithEvents Btn_Cadastraativos As Button
    Friend WithEvents Btn_ConsultarCarteira As Button
    Friend WithEvents Btn_ConsultarAtivos As Button
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
End Class
