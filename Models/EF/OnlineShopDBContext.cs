namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDBContext : DbContext
    {
        public OnlineShopDBContext()
            : base("name=OnlineShopDBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<GroupSlide> GroupSlides { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<News> Newses { get; set; }
        public virtual DbSet<NewsTag> NewsTags { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<PostCategory> PostCategories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SupportOnline> SupportOnlines { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Function>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GroupSlide>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<GroupSlide>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<GroupSlide>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.CssClass)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.GroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<MenuType>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<MenuType>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MenuType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.RelatedNewses)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<NewsTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.GroupID)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.FunctionID)
                .IsUnicode(false);

            modelBuilder.Entity<Photo>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PostCategory>()
                .HasMany(e => e.Posts)
                .WithRequired(e => e.PostCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("PostTags").MapLeftKey("PostID").MapRightKey("TagID"));

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);

            modelBuilder.Entity<ProductTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.GroupID)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.UniqueKey)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.ProductTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserActivityLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivityLog>()
                .Property(e => e.SessionID)
                .IsUnicode(false);

            modelBuilder.Entity<UserActivityLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .Property(e => e.GroupID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PasswordLevel2)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Point)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<VisitorStatistic>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.LanguageCode)
                .IsUnicode(false);
        }
    }
}
