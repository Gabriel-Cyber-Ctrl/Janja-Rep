create database pds_app_web;
use pds_app_web;

create table processos (
	id_pro INT NOT NULL AUTO_INCREMENT,
    numero_pro VARCHAR(200) NOT NULL,
    interessado_pro VARCHAR(200) NOT NULL,
    assunto_pro VARCHAR(300) NOT NULL,
    descricao_pro TEXT NOT NULL,
    situacao_pro VARCHAR(50) NOT NULL default "Aberto",
    
    PRIMARY KEY(id_pro)
);

INSERT INTO processos 
(numero_pro, interessado_pro, assunto_pro, descricao_pro, situacao_pro)
VALUES
('2026/000001', 'João da Silva', 'Solicitação de Alvará', 'Solicitação de emissão de alvará para funcionamento de estabelecimento comercial.', 'Aberto'),
('2026/000002', 'Maria Oliveira', 'Pedido de Licença', 'Pedido de licença para realização de atividade comercial no município.', 'Em Análise'),
('2026/000003', 'Empresa ABC Ltda.', 'Regularização Cadastral', 'Solicitação de regularização dos dados cadastrais da empresa.', 'Aberto'),
('2026/000004', 'Carlos Souza', 'Requerimento de Documento', 'Requerimento para emissão de documento administrativo.', 'Concluído'),
('2026/000005', 'Ana Pereira', 'Solicitação de Informação', 'Solicitação de informações referentes a um processo administrativo.', 'Em Análise'),
('2026/000006', 'Comercial São José Ltda.', 'Pedido de Autorização', 'Pedido de autorização para execução de atividade comercial.', 'Aberto'),
('2026/000007', 'Pedro Santos', 'Revisão de Cadastro', 'Solicitação de revisão e atualização de informações cadastrais.', 'Concluído'),
('2026/000008', 'Fernanda Costa', 'Solicitação de Serviço', 'Solicitação de prestação de serviço pela administração pública.', 'Em Análise'),
('2026/000009', 'Mercado Central Ltda.', 'Renovação de Licença', 'Pedido de renovação de licença de funcionamento do estabelecimento.', 'Aberto'),
('2026/000010', 'Roberto Almeida', 'Recurso Administrativo', 'Apresentação de recurso administrativo referente a decisão anterior.', 'Em Análise');

