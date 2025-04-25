# Invoice Master

## Contexte

Ce projet a été développé dans le cadre de mon **BTS SIO option SLAM**, pour l’épreuve **E6, Mise en œuvre d’une solution applicative**.  
Il s’agit d’une application **Windows Forms** en **C# orienté objet**, dont l’objectif est de gérer l’ensemble du cycle de facturation et de gestion de stock au sein d’une petite structure :

- **Clients & Fournisseurs**  
- **Produits & Catégories**  
- **Achats / Ventes**  
- **Inventaire**  
- **Transactions** et **impression de factures** (aperçu PDF via DGVPrinterHelper)

## Architecture

L’application suit une architecture **3 tiers** :

1. **UI (Windows Forms)**  
   - Formulaires modulaires (`frmLogin`, `frmUsers`, `frmProducts`, `frmPurchasesAndSales`, `frmInventory`, …)  
   - Contrôles DataGridView, ComboBox, TextBox, boutons CRUD  
2. **BLL (Business Logic Layer)**  
   - Classes métier : `UserBLL`, `ProductsBLL`, `TransactionsBLL`, `TransactionDetailBLL`  
   - Encapsulation des règles de gestion (calcul de sous-total, remise, TVA…)  
3. **DAL (Data Access Layer)**  
   - ADO.NET avec **Microsoft.Data.SqlClient**  
   - `userDAL`, `ProductsDAL`, `TransactionDAL`, `TransactionDetailDAL`  
   - Gestion des transactions SQL avec `TransactionScope`  
   - Chaîne de connexion paramétrée dans `App.config`

## Fonctionnalités principales

- **Authentification**  
  - Formulaire de connexion avec gestion des rôles (Administrateur, Utilisateur)
- **Gestion des utilisateurs**  
  - Création / Modification / Suppression / Recherche
- **Gestion des produits**  
  - CRUD produits, catégories, stocks (mise à jour auto. après achats/ventes)
- **Achats & Ventes**  
  - Saisie multi-lignes de transaction  
  - Calcul automatique : sous-total, remise, TVA, total, reste à payer  
  - Impression d’une facture (aperçu PDF)
- **Inventaire**  
  - Filtrage dynamique par catégorie
- **Base de données**  
  - Tables : `tbl_users`, `tbl_products`, `tbl_transactions`, `tbl_transaction_detail`, …

## Technologies utilisées

- **Langage :** C# (POO)  
- **Framework :** .NET Framework 4.7.2  
- **UI :** Windows Forms  
- **Accès aux données :** ADO.NET / Microsoft.Data.SqlClient  
- **Base de données :** SQL Server (Express / LocalDB)  
- **Impression :** DGVPrinterHelper (aperçu et PDF)

## Prérequis

1. Visual Studio 2019 (ou supérieur)  
2. .NET Framework 4.7.2  
3. SQL Server Express ou LocalDB  
4. Git (pour cloner le dépôt)

---

## Installation

1. **Cloner** ce dépôt :  
   ```bash
   git clone https://github.com/<votre-utilisateur>/invoice-master.git
   cd invoice-master
   ```
2. **Ouvrir** la solution InvoiceMaster.sln dans visual studio
   
3. **Restaurer** les packages NuGet si nécessaire (clic droit sur la solution → Restore NuGet Packages).
  
4. Configurer la chaîne de connexion :

   - Ouvrez App.config
   - Vérifiez la section <connectionStrings> :
   ```
   <connectionStrings>
     <add name="connstrng"
          connectionString="Data Source=(localdb)\MSSQLLocalDB;
                            Initial Catalog=InvoiceMaster;
                            Integrated Security=True" />
   </connectionStrings>
   ```

5. Créer la base de données et les tables :
     - Exécutez le script SQL fourni dans Database/InvoiceMasterDBScript.sql
     - Celui-ci crée les tables (tbl_users, tbl_products, tbl_transactions, tbl_transaction_detail, …) et les contraintes.

6. Compiler et lancer l’application (F5).


