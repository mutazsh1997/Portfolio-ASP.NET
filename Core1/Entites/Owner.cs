namespace Core1.Entites
{
    public class Owner : EntitesBase {

        public string FullName { get; set; }
        public string Portifolio { get; set; }
        public string Photo { get; set; }

        public Adress adress { get; set; }
    }
}
