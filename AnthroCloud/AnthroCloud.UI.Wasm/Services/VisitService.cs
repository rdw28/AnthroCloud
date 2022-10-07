﻿using AnthroCloud.Entities;
using System.Net.Http.Json;

namespace AnthroCloud.UI.Wasm.Services
{
    public class VisitService : IVisitService
    {
        private readonly HttpClient _httpClient;

        public VisitService(HttpClient httpClient) 
        {
            this._httpClient = httpClient;
        }

        public async Task<Visit> CreateVisit(Visit newVisit)
        {
            await _httpClient.PostAsJsonAsync<Visit>(_httpClient.BaseAddress, newVisit);
            return newVisit;
        }

        public async Task<Visit> GetVisit(int visitId)
        {
            return await _httpClient.GetFromJsonAsync<Visit>($"{_httpClient.BaseAddress}{visitId}");
        }

        public async Task<IEnumerable<Visit>> GetVisits(int patientId)
        {
            return await _httpClient.GetFromJsonAsync<List<Visit>>(_httpClient.BaseAddress + "patient/" + patientId);
        }
 
        public async Task<Visit> UpdateVisit(int visitId, Visit updatedVisit)
        {
            await _httpClient.PutAsJsonAsync<Visit>($"{_httpClient.BaseAddress}{visitId}", updatedVisit);
            return updatedVisit;
        }

        public async Task DeleteVisit(int visitId)
        {
            await _httpClient.DeleteAsync($"{_httpClient.BaseAddress}{visitId}");
        }
    }
}