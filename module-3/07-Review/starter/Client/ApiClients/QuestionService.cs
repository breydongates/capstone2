﻿using RestSharp;
using RestSharp.Authenticators;
using SallyClient.Data;
using System;
using System.Collections.Generic;

namespace SallyClient.ApiClients
{
    public class QuestionService
    {
        private readonly string BASE_URL;
        private readonly RestClient client;

        public QuestionService()
        {
            this.BASE_URL = AuthService.API_BASE_URL + "questions";

            this.client = new RestClient();
        }
        public void UpdateToken(string tokenJwt)
        {
            if (string.IsNullOrEmpty(tokenJwt))
            {
                this.client.Authenticator = null;
            }
            else
            {
            this.client.Authenticator = new JwtAuthenticator(tokenJwt);
                
            }
        }

        public List<API_Question> GetAllQuestions()
        {
            RestRequest request = new RestRequest(BASE_URL);

            var response = client.Get<List<API_Question>>(request); //var says the same thng as IRestResponse<List<API_Question>> response = client.Get

            if (response.IsSuccessful && response.ResponseStatus == ResponseStatus.Completed)
            {
                return response.Data;
            }
            else
            {
                Console.WriteLine("An error occurred fetching questions");

                return new List<API_Question>();
            }
        }

        public API_Question GetRandomQuestion()
        {
            RestRequest request = new RestRequest(BASE_URL + "/random");

            var response = client.Get<API_Question>(request);

            if (response.IsSuccessful && response.ResponseStatus == ResponseStatus.Completed)
            {
                return response.Data;
            }
            else
            {
                Console.WriteLine("An error occurred fetching a random question");

                return null;
            }
        }

        public API_Question CreateQuestion(API_Question question)
        {
            RestRequest request = new RestRequest(BASE_URL);
            request.AddJsonBody(question);

            var response = client.Post<API_Question>(request);

            if (response.IsSuccessful && response.ResponseStatus == ResponseStatus.Completed)
            {
                return response.Data;
            }
            else
            {
                Console.WriteLine("An error occurred creating a new question");

                return null;
            }
        }

        public void DeleteQuestion(int id)
        {
            RestRequest request = new RestRequest($"{BASE_URL}/{id}");

            var response = client.Delete(request);

            if (response.IsSuccessful && response.ResponseStatus == ResponseStatus.Completed)
            {
                return;
            }
            else
            {
                Console.WriteLine("An error occurred deleting the question");
            }
        }
    }
}
