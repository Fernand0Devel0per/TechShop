﻿using TechShop.DAL.Interface;
using TechShop.Domain;
using TechShop.Helpers.Data;
using TechShop.Helpers.Enums;
using System.Data.SqlClient;

namespace TechShop.DAL
{
    public class StatusDao : IStatusDao
    {
        private const string ColumnId = "Id";
        private const string ColumnCode = "Code";
        private const string ColumnDescription = "Description";

        private readonly string _connectionString;
        public StatusDao(IConfiguration configuration)
        {
            _connectionString = configuration.GetDefaultConnectionString();
        }

        public async Task<Status> FindByCodeAsync(StatusCode code)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Statuses WHERE Code = @code";
            command.Parameters.AddWithValue("@code", code);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Status
                {
                    Id = reader.GetGuid(reader.GetOrdinal(ColumnId)),
                    Code = reader.GetInt32(reader.GetOrdinal(ColumnCode)),
                    Description = reader.GetString(reader.GetOrdinal(ColumnDescription)),
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Status>> FindAllAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Statuses";

            var statuses = new List<Status>();

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var status = new Status
                {
                    Id = reader.GetGuid(reader.GetOrdinal(ColumnId)),
                    Code = reader.GetInt32(reader.GetOrdinal(ColumnCode)),
                    Description = reader.GetString(reader.GetOrdinal(ColumnDescription))
                };

                statuses.Add(status);
            }
            return statuses;
        }

        public async Task<Status> GetByIdAsync(Guid id)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Statuses WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Status
                {
                    Id = reader.GetGuid(reader.GetOrdinal(ColumnId)),
                    Code = reader.GetInt32(reader.GetOrdinal(ColumnCode)),
                    Description = reader.GetString(reader.GetOrdinal(ColumnDescription)),
                };
            }
            else
            {
                return null;
            }
        }
    }
}
