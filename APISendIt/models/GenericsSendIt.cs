namespace APISendIt.models
{
    public class GenericsSendIt<T>
    {
        public int Id { get; set; }
        public T KurirID { get; set; }
        public T PengirimID { get; set; }

        public GenericsSendIt(int Id, T KurirID, T PengirimID)
        {
            this.Id = Id;
            KurirID = KurirID;
            PengirimID = PengirimID;
        }
    }
}
