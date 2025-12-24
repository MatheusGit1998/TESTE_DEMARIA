-- Tabela de itens da venda
CREATE TABLE itens_venda (
    id_item SERIAL PRIMARY KEY,
    id_venda INTEGER NOT NULL,
    id_produto INTEGER NOT NULL,
    quantidade INTEGER NOT NULL CHECK (quantidade > 0),
    preco_unitario NUMERIC(20,2) NOT NULL CHECK (preco_unitario >= 0),
    preco_total NUMERIC(20,2) NOT NULL CHECK (preco_total >= 0),
    FOREIGN KEY (id_venda) REFERENCES vendas(id_venda),
    FOREIGN KEY (id_produto) REFERENCES cadastro_de_produtos(id_produto)
);