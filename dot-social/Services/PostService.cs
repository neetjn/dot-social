using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IPostService {
    Post GetById(int postId);
    Post Create(PostCreationDto postDto);
    void Update(int postId, PostUpdateDto postDto);
    void Delete(int postId);
  }

  public interface PostService : IPostService {
    private DataContext _context;

    public UserService(DataContext context) {
      _context = context;
    }
  }
}
