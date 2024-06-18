namespace APISendIt.models
{
    public class GenericsSendItAPI<T>
    {
        public int Id { get; set; }
        public T KurirID { get; set; }
        public T PengirimID { get; set; }

        public GenericsSendItAPI(int Id, T KurirID, T PengirimID)
        {
            this.Id = Id;
            KurirID = KurirID;
            PengirimID = PengirimID;
        }
    }
}
