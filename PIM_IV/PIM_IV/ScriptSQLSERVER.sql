CREATE DATABASE PIM_IV;

CREATE TABLE Funcionarios
(
    Nome VARCHAR(255) NOT NULL,
    CPF VARCHAR(20) NOT NULL PRIMARY KEY,
    RG VARCHAR(20) NOT NULL,
    DataNascimento VARCHAR(20) NOT NULL,
    EstadoCivil VARCHAR(20) NOT NULL,
    EnderecoCompleto VARCHAR(255) NOT NULL,
    PIS VARCHAR(20) NOT NULL,
    TituloEleitor VARCHAR(20) NOT NULL,
    CTPS VARCHAR(20) NOT NULL,
    Reservista VARCHAR(20),
    Cargo VARCHAR(50) NOT NULL,
    SalarioBase DECIMAL(10, 2) NOT NULL,
    IndicadorPlanoSaude VARCHAR(20) NOT NULL,
    IndicadorPlanoOdonto VARCHAR(20) NOT NULL,
    IndicadorValeTransporte VARCHAR(20) NOT NULL,
    IndicadorValeRefeicao VARCHAR(20) NOT NULL,
    IndicadorValeAlimentacao VARCHAR(20) NOT NULL,
    Banco VARCHAR(20) NOT NULL,
    Agencia VARCHAR(20) NOT NULL,
    Conta VARCHAR(20) NOT NULL
);

CREATE TABLE FolhaDePagamento 
(
    ID INT NOT NULL PRIMARY KEY,
    CPF VARCHAR(20) NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    MesReferencia DATE NOT NULL,
    ProventoAdicionalNoturno DECIMAL(10, 2) NOT NULL,
    ProventoHorasExtras DECIMAL(10, 2) NOT NULL,
    ProventoComissao DECIMAL(10, 2) NOT NULL,
    DescontoINSS DECIMAL(10, 2) NOT NULL,
    DescontoIRRF DECIMAL(10, 2) NOT NULL,
    DescontoVT DECIMAL(10, 2) NOT NULL,
    DescontoVA DECIMAL(10, 2) NOT NULL,
    DescontoVR DECIMAL(10, 2) NOT NULL,
    DescontoPS DECIMAL(10, 2) NOT NULL,
    DescontoPO DECIMAL(10, 2) NOT NULL,
    SalarioBase DECIMAL(10, 2) NOT NULL,
    SalarioBruto DECIMAL(10, 2) NOT NULL,
    SalarioLiquido DECIMAL(10, 2) NOT NULL,
);