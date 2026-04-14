using API.DTOs;
using API.Entities;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces;

public interface IMessagesRepository
{
   void Add(Message message);
   void Delete(Message message);
   Task<Message?> Get(string messageId);
   Task<PaginationResult<MessageResponse>> GetForMember();
    Task<ActionResult<PaginationResult<MessageResponse>>> GetForMember(MessageParams messageParams);
    Task<IReadOnlyList<MessageResponse>> GetThread(string currentMemberId, string recipientId);
   Task<bool> SaveAllAsync(); 
}