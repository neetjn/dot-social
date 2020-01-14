using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IPostService {
    Post Create(PostCreationDto postDto);
    Post GetById(int postId);
    void Update(int postId, PostUpdateDto postDto);
    void Delete(int postId);
  }

  public class PostService : IPostService {
    private DataContext context;

    public PostService(DataContext context) {
      this.context = context;
    }

    public Post Create(PostCreationDto postDto) {
    }

    public Post GetById(int postId) {
      return context.Posts.Single(p => p.id == postId);
    }

    void Update(int postId) {

    }

    void Delete(int postId) {

    }
  }
}
