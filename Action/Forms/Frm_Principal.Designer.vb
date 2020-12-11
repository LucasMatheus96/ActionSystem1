<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsl_UsuarioLogado})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarCarteiraToolStripMenuItem, Me.ConsultarCarteiraToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'CadastrarCarteiraToolStripMenuItem
        '
        Me.CadastrarCarteiraToolStripMenuItem.Name = "CadastrarCarteiraToolStripMenuItem"
        Me.CadastrarCarteiraToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CadastrarCarteiraToolStripMenuItem.Text = "Cadastrar Carteira "
        '
        'ConsultarCarteiraToolStripMenuItem
        '
        Me.ConsultarCarteiraToolStripMenuItem.Name = "ConsultarCarteiraToolStripMenuItem"
        Me.ConsultarCarteiraToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConsultarCarteiraToolStripMenuItem.Text = "Consultar Carteira"
        '
        'InvestimentosToolStripMenuItem
        '
        Me.InvestimentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.GerenciarToolStripMenuItem})
        Me.InvestimentosToolStripMenuItem.Name = "InvestimentosToolStripMenuItem"
        Me.InvestimentosToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.InvestimentosToolStripMenuItem.Text = "Investimentos"
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        Me.AdicionarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdicionarToolStripMenuItem.Text = "Adicionar"
        '
        'GerenciarToolStripMenuItem
        '
        Me.GerenciarToolStripMenuItem.Name = "GerenciarToolStripMenuItem"
        Me.GerenciarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GerenciarToolStripMenuItem.Text = "Gerenciar"
        '
        'AtivosToolStripMenuItem
        '
        Me.AtivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarAtivosToolStripMenuItem, Me.ConsultarAtivosToolStripMenuItem})
        Me.AtivosToolStripMenuItem.Name = "AtivosToolStripMenuItem"
        Me.AtivosToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AtivosToolStripMenuItem.Text = "Ativos"
        '
        'CadastrarAtivosToolStripMenuItem
        '
        Me.CadastrarAtivosToolStripMenuItem.Name = "CadastrarAtivosToolStripMenuItem"
        Me.CadastrarAtivosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CadastrarAtivosToolStripMenuItem.Text = "Cadastrar Ativos"
        '
        'ConsultarAtivosToolStripMenuItem
        '
        Me.ConsultarAtivosToolStripMenuItem.Name = "ConsultarAtivosToolStripMenuItem"
        Me.ConsultarAtivosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ConsultarAtivosToolStripMenuItem.Text = "Consultar Ativos"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EfetuarNovoAcessoToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'EfetuarNovoAcessoToolStripMenuItem
        '
        Me.EfetuarNovoAcessoToolStripMenuItem.Name = "EfetuarNovoAcessoToolStripMenuItem"
        Me.EfetuarNovoAcessoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EfetuarNovoAcessoToolStripMenuItem.Text = "Efetuar Novo acesso "
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
