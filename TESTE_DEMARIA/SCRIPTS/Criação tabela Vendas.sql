
CREATE TABLE public.vendas (
    id_venda SERIAL PRIMARY KEY,
    cliente_id INTEGER NOT NULL,
    data_venda TIMESTAMP WITH TIME ZONE,
    valor_total NUMERIC(20,2),
    FOREIGN KEY (cliente_id) REFERENCES public.cadastro_de_clientes(cliente_id)
);
