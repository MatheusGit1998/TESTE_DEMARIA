
CREATE TABLE public.cadastro_de_produtos (
    id_produto SERIAL PRIMARY KEY,
    nome VARCHAR(100),
    descricao VARCHAR(100),
    valor NUMERIC(30,2),
    estoque INTEGER,
    criado_em TIMESTAMP WITHOUT TIME ZONE
);
