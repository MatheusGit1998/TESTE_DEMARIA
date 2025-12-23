ALTER TABLE Cadastro_de_Produtos
ADD CONSTRAINT chk_preco CHECK (valor>=0),
ADD CONSTRAINT chk_estoque CHECK (estoque>=0)
