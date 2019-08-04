namespace Projeto.Infra.Repositories.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 300,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "IX_Email",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                                },
                            }),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 200),
                        Cidadae = c.String(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50),
                        Cep = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.IdEndereco)
                .ForeignKey("dbo.Cliente", t => t.IdEndereco)
                .Index(t => t.IdEndereco);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Endereco", "IdEndereco", "dbo.Cliente");
            DropIndex("dbo.Endereco", new[] { "IdEndereco" });
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Email",
                        new Dictionary<string, object>
                        {
                            { "IX_Email", "IndexAnnotation: { IsUnique: True }" },
                        }
                    },
                });
        }
    }
}
