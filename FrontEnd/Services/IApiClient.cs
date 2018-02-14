﻿using ConferenceDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IApiClient
{
    Task<List<SessionResponse>> GetSessionsAsync();
    Task<SessionResponse> GetSessionAsync(int id);
    Task<List<SpeakerResponse>> GetSpeakersAsync();
    Task<SpeakerResponse> GetSpeakerAsync(int id);
    Task PutSessionAsync(Session session);
    Task<List<SearchResult>> SearchAsync(string query);
    Task AddAttendeeAsync(Attendee attendee);
    Task<AttendeeResponse> GetAttendeeAsync(string name);
    Task DeleteSessionAsync(int id);
}