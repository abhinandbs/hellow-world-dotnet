
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Exercises
{
    
        interface IRestClient<T, U>
        {

            U postMetrhod(T requestModel);

        }

        public class DataFetchingService<T, U> : IRestClient<T, U> where T:IRequestModel where U : IResponseModel
        {

           
           public IResponseModel responseModel1 { get; set; }
         
            public U postMetrhod(T requestModel)
            {


                var process = (T)requestModel;


            responseModel1.ResponseData = process.RequestData;

                return  (U)responseModel1;
            }

           
    }


       public interface IRequestModel
        {

            string? RequestData { get; set; }

        }

        public interface IResponseModel
        {

            string? ResponseData { get; set; }

        }
        public class  RequestModel:IRequestModel{

            public string? RequestData { get; set; }
        }


        public class ResponseModel:IResponseModel
        {
 
            public string? ResponseData
            {
                get;set;
            }

        }

    public class ResponseModel2 : IResponseModel
    {

        public string? ResponseData
        {
            get; set;
        }
        public string? ResponseData2
        {
            get; set;
        }
        public string? ResponseData3
        {
            get; set;
        }
    }
    public static class GenericSample
        {

            public static void MainMethod()
            {

                RequestModel requestModel = new RequestModel();
                ResponseModel responseModel = new ResponseModel();

                DataFetchingService<RequestModel, ResponseModel> dataFetchingService = new DataFetchingService<RequestModel, ResponseModel>();
                     dataFetchingService.responseModel1 = responseModel;
                 requestModel.RequestData = "abhinand";
                var result = dataFetchingService.postMetrhod(requestModel);

                Console.WriteLine(result.ResponseData);


            }
        }


    
}
