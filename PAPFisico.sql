/* PAPLogico: */

CREATE TABLE Utilizador (
    ID int  PRIMARY KEY,
    Nome nvarchar(254),
    Email nvarchar(254),
    Password nvarchar(254),
    fk_Grupos_ID int 
);

CREATE TABLE Grupos (
    ID int  PRIMARY KEY,
    Nome nvarchar(254)
);

CREATE TABLE Maquinas (
    ID int  PRIMARY KEY,
    Cor nvarchar(254),
    Dimensoes nvarchar(254),
    Preco float,
    Date_Time_Adicionado datetime,
    Produto_Imagem image,
    fk_Utilizador_ID int ,
    fk_Marca_Modelo_ID int 
);

CREATE TABLE AddOns (
    ID int  PRIMARY KEY,
    Descricao nvarchar(254),
    Preco_Base float,
    fk_Utilizador_ID int ,
    fk_Add_Ons_Grupos_ID int 
);

CREATE TABLE Simulacoes (
    ID int  PRIMARY KEY,
    Data_Simulacao datetime,
    fk_Utilizador_ID int 
);

CREATE TABLE Equipamentos (
    ID int  PRIMARY KEY,
    Preco float,
    fk_Maquinas_ID int ,
    fk_Simulacoes_ID int 
);

CREATE TABLE Permisscoes_List (
    ID int  PRIMARY KEY,
    Nome nvarchar(254)
);

CREATE TABLE Permicoes_Gerais (
    ID int  PRIMARY KEY,
    Estado bit,
    fk_Permisscoes_List_ID int ,
    fk_Grupos_ID int 
);

CREATE TABLE Add_Ons_Grupos (
    ID int  PRIMARY KEY,
    Nome nvarchar(254)
);

CREATE TABLE Marca_Modelo (
    Nome_Modelo nvarchar(254),
    ID int  PRIMARY KEY,
    fk_Marca_ID int ,
    fk_Modelo_ID int 
);

CREATE TABLE Marca (
    ID int  PRIMARY KEY,
    Nome nvarchar(254)
);

CREATE TABLE Modelo (
    Nome nvarchar(254),
    ID int  PRIMARY KEY
);

CREATE TABLE Modelo_AddOns (
    ID int  PRIMARY KEY,
    Preco_Relacao float,
    fk_AddOns_ID int ,
    fk_Marca_Modelo_ID int 
);

CREATE TABLE AddOns_Equip (
    ID int  PRIMARY KEY,
    fk_Modelo_AddOns_ID int ,
    fk_Equipamentos_ID int 
);
 
ALTER TABLE Utilizador ADD CONSTRAINT FK_Utilizador_2
    FOREIGN KEY (fk_Grupos_ID)
    REFERENCES Grupos (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Maquinas ADD CONSTRAINT FK_Maquinas_2
    FOREIGN KEY (fk_Utilizador_ID)
    REFERENCES Utilizador (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Maquinas ADD CONSTRAINT FK_Maquinas_3
    FOREIGN KEY (fk_Marca_Modelo_ID)
    REFERENCES Marca_Modelo (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE AddOns ADD CONSTRAINT FK_AddOns_2
    FOREIGN KEY (fk_Utilizador_ID)
    REFERENCES Utilizador (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE AddOns ADD CONSTRAINT FK_AddOns_3
    FOREIGN KEY (fk_Add_Ons_Grupos_ID)
    REFERENCES Add_Ons_Grupos (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Simulacoes ADD CONSTRAINT FK_Simulacoes_2
    FOREIGN KEY (fk_Utilizador_ID)
    REFERENCES Utilizador (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Equipamentos ADD CONSTRAINT FK_Equipamentos_2
    FOREIGN KEY (fk_Maquinas_ID)
    REFERENCES Maquinas (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Equipamentos ADD CONSTRAINT FK_Equipamentos_3
    FOREIGN KEY (fk_Simulacoes_ID)
    REFERENCES Simulacoes (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Permicoes_Gerais ADD CONSTRAINT FK_Permicoes_Gerais_2
    FOREIGN KEY (fk_Permisscoes_List_ID)
    REFERENCES Permisscoes_List (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Permicoes_Gerais ADD CONSTRAINT FK_Permicoes_Gerais_3
    FOREIGN KEY (fk_Grupos_ID)
    REFERENCES Grupos (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Marca_Modelo ADD CONSTRAINT FK_Marca_Modelo_2
    FOREIGN KEY (fk_Marca_ID)
    REFERENCES Marca (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Marca_Modelo ADD CONSTRAINT FK_Marca_Modelo_3
    FOREIGN KEY (fk_Modelo_ID)
    REFERENCES Modelo (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Modelo_AddOns ADD CONSTRAINT FK_Modelo_AddOns_2
    FOREIGN KEY (fk_AddOns_ID)
    REFERENCES AddOns (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE Modelo_AddOns ADD CONSTRAINT FK_Modelo_AddOns_3
    FOREIGN KEY (fk_Marca_Modelo_ID)
    REFERENCES Marca_Modelo (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE AddOns_Equip ADD CONSTRAINT FK_AddOns_Equip_2
    FOREIGN KEY (fk_Modelo_AddOns_ID)
    REFERENCES Modelo_AddOns (ID)
    ON DELETE RESTRICT;
 
ALTER TABLE AddOns_Equip ADD CONSTRAINT FK_AddOns_Equip_3
    FOREIGN KEY (fk_Equipamentos_ID)
    REFERENCES Equipamentos (ID)
    ON DELETE RESTRICT;