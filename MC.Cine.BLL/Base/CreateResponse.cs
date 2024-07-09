namespace MC.Cine.BLL.Base
{
    public class CreateResponse
    {
        protected CreateResponse() { }

        /// <summary>
        /// Response para casos donde no retorna datos de la BD
        /// </summary>
        /// <returns></returns>
        public static ResponseDetails ResponseNotOk()
        {
            //Cargo el objeto en caso de ser una excepcion
            ResponseDetails response = new()
            {
                Success = false
            };

            return response;
        }

        /// <summary>
        /// Response para casos donde retornó valores de la BD
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static ResponseDetails ResponseOk(Object? Data)
        {
            ResponseDetails response = new()
            {
                Success = true,
                Data = Data
            };

            return response;
        }
    }
}
