﻿using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System;

namespace PersonRepository.Factory
{
    public class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repoType)
        {
            IPersonRepository repo = null;

            switch (repoType)
            {
                case "Service": repo = new ServiceRepository();
                    break;
                case "CSV": repo = new CSVRepository();
                    break;
                case "SQL": repo = new SQLRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid Repository Type");
            }


            return repo;
        }
    }
}
