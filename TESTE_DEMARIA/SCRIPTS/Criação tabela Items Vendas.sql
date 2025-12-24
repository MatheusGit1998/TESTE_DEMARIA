
CREATE TABLE public.itens_venda (
    id_item SERIAL PRIMARY KEY,
    id_venda INTEGER NOT NULL,
    id_produto INTEGER NOT NULL,
    quantidade INTEGER,
    preco_unitario NUMERIC(20,2),
    FOREIGN KEY (id_venda) REFERENCES public.vendas(id_venda),
    FOREIGN KEY (id_produto) REFERENCES public.cadastro_de_produtos(id_produto)
);