CREATE TABLE teste_vaga (
    Id INT PRIMARY KEY,
    descricao VARCHAR(255) NOT NULL,
    data DATE NOT NULL,
    valor DECIMAL(10, 2) NOT NULL,
    avulso BOOLEAN NOT NULL,
    status VARCHAR(50) NOT NULL
);