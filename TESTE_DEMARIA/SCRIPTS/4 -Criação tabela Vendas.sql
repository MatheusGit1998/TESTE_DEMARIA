-- Tabela de vendas
CREATE TABLE vendas (
    id_venda SERIAL PRIMARY KEY,
    cliente_id INTEGER NOT NULL,
    data_venda TIMESTAMP(0) WITHOUT TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL,
    valor_total NUMERIC(20,2) NOT NULL CHECK (valor_total >= 0),
    FOREIGN KEY (cliente_id) REFERENCES cadastro_de_clientes(cliente_id)
);