using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace memelation___backend.Models
{
    public partial class mydbContext : DbContext
    {
        public mydbContext()
        {
        }

        public mydbContext(DbContextOptions<mydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbComentario> TbComentario { get; set; }
        public virtual DbSet<TbListaFofa> TbListaFofa { get; set; }
        public virtual DbSet<TbListaNegra> TbListaNegra { get; set; }
        public virtual DbSet<TbLogin> TbLogin { get; set; }
        public virtual DbSet<TbMemelation> TbMemelation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseMySql("host=localhost;user=root;password=12345;database=mydb", x => x.ServerVersion("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentario)
                    .HasName("PRIMARY");

                entity.ToTable("tb_comentario");

                entity.HasIndex(e => e.IdMeme)
                    .HasName("id_meme");

                entity.Property(e => e.IdComentario).HasColumnName("id_comentario");

                entity.Property(e => e.DsComentario)
                    .HasColumnName("ds_comentario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IdMeme).HasColumnName("id_meme");

                entity.HasOne(d => d.IdMemeNavigation)
                    .WithMany(p => p.TbComentario)
                    .HasForeignKey(d => d.IdMeme)
                    .HasConstraintName("tb_comentario_ibfk_1");
            });

            modelBuilder.Entity<TbListaFofa>(entity =>
            {
                entity.HasKey(e => e.IdListaFofa)
                    .HasName("PRIMARY");

                entity.ToTable("tb_lista_fofa");

                entity.Property(e => e.IdListaFofa).HasColumnName("id_lista_fofa");

                entity.Property(e => e.BtColocariaPotinho).HasColumnName("bt_colocaria_potinho");

                entity.Property(e => e.DsPorque)
                    .IsRequired()
                    .HasColumnName("ds_porque")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtNiver)
                    .HasColumnName("dt_niver")
                    .HasColumnType("date");

                entity.Property(e => e.NmFofura)
                    .IsRequired()
                    .HasColumnName("nm_fofura")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbListaNegra>(entity =>
            {
                entity.HasKey(e => e.IdListaNegra)
                    .HasName("PRIMARY");

                entity.ToTable("tb_lista_negra");

                entity.Property(e => e.IdListaNegra).HasColumnName("id_lista_negra");

                entity.Property(e => e.DsFoto)
                    .HasColumnName("ds_foto")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'user.png'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsLocal)
                    .HasColumnName("ds_local")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsMotivo)
                    .HasColumnName("ds_motivo")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmPessoa)
                    .HasColumnName("nm_pessoa")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbLogin>(entity =>
            {
                entity.HasKey(e => e.IdLogin)
                    .HasName("PRIMARY");

                entity.ToTable("tb_login");

                entity.Property(e => e.IdLogin).HasColumnName("id_login");

                entity.Property(e => e.DsLogin)
                    .HasColumnName("ds_login")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasColumnName("ds_senha")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMemelation>(entity =>
            {
                entity.HasKey(e => e.IdMemelation)
                    .HasName("PRIMARY");

                entity.ToTable("tb_memelation");

                entity.Property(e => e.IdMemelation).HasColumnName("id_memelation");

                entity.Property(e => e.BtMaior).HasColumnName("bt_maior");

                entity.Property(e => e.DsCategoria)
                    .IsRequired()
                    .HasColumnName("ds_categoria")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsHashtags)
                    .IsRequired()
                    .HasColumnName("ds_hashtags")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DtInclusao)
                    .HasColumnName("dt_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImgMeme)
                    .HasColumnName("img_meme")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'user.png'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmAutor)
                    .IsRequired()
                    .HasColumnName("nm_autor")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
