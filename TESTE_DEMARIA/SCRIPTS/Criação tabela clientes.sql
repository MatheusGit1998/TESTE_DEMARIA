
CREATE TABLE public.cadastro_de_clientes (
    cliente_id SERIAL PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100),
    telefone VARCHAR(20),
    cpf VARCHAR(100),
    logradouro VARCHAR(100),
    numero VARCHAR(100),
    complemento VARCHAR(100),
    bairro VARCHAR(100),
    localidade VARCHAR(100),
    uf VARCHAR(100),
    cep VARCHAR(100),
    data_cadastro TIMESTAMP WITHOUT TIME ZONE
);

