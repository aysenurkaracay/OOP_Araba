namespace OOPArabaOdev
{
    public enum AracTuru { Binek, Ticari }
    public enum KasaTipi { Kamyonet, Otobüs, Minibüs, Sedan, MPV }
    public enum Marka { FIAT, FORD, VOLKSWAGEN, RENAULT, BMW, HONDA }
    public enum Model { DOBLO, FOCUS, GOLF, PASSAT, MEGANE, CADY, X5, CiViC }
    public enum SanzimanTuru { Düz, Otomatik }
    public enum YakitTuru { Benzinli, Dizel, LPG }

    public class Arac
    {
        internal string ResimYolu;
        private int modelYili;
        private int motorGucu;

        public AracTuru AracTuru { get; set; }
        public KasaTipi KasaTipi { get; set; }
        public Marka Marka { get; set; }
        public Model Model { get; set; }
        public SanzimanTuru SanzimanTuru { get; set; }
        public YakitTuru YakitTuru { get; set; }

        public int ModelYili
        {
            get { return modelYili; }
            set
            {
                if (value < 2005)
                {
                    throw new ArgumentException("2005 yılından küçük araç işlem görmemektedir");
                }
                modelYili = value;
            }
        }

        public int MotorGucu
        {
            get { return motorGucu; }
            set
            {
                if (value < 1000)
                {
                    throw new ArgumentException("Motor Gücü en az 1000 olabilir");
                }
                motorGucu = value;
            }
        }
    }
}
