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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Grb_Produtos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgw_Ativos = New System.Windows.Forms.DataGridView()
        Me.Grb_Produtos.SuspendLayout()
        CType(Me.Dgw_Ativos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb_Filtro
        '
        Me.Grb_Filtro.Location = New System.Drawing.Point(12, 26)
        Me.Grb_Filtro.Name = "Grb_Filtro"
        Me.Grb_Filtro.Size = New System.Drawing.Size(737, 81)
        Me.Grb_Filtro.TabIndex = 0
        Me.Grb_Filtro.TabStop = False
        Me.Grb_Filtro.Text = "Filtro"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Dgw_Ativos
        '
        Me.Dgw_Ativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgw_Ativos.Location = New System.Drawing.Point(15, 33)
        Me.Dgw_Ativos.Name = "Dgw_Ativos"
        Me.Dgw_Ativos.Size = New System.Drawing.Size(722, 264)
        Me.Dgw_Ativos.TabIndex = 0
        '
        'Frm_GerenciarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 487)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grb_Produtos)
        Me.Controls.Add(Me.Grb_Filtro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_GerenciarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_GerenciarProduto"
        Me.Grb_Produtos.ResumeLayout(False)
        CType(Me.Dgw_Ativos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grb_Filtro As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Grb_Produtos As GroupBox
    Friend WithEvents Dgw_Ativos As DataGridView
    Friend WithEvents Label1 As Label
End Class
