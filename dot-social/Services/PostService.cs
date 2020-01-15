using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IPostService {
    Post Create(int userId, PostCreationDto postDto);
    Post GetById(int postId);
    void Update(int postId, PostUpdateDto postDto);
    void Delete(int postId);
  }

  public class PostService : IPostService {
    private DataContext context;

    public PostService(DataContext context) {
      this.context = context;
    }

    public Post Create(int userId, PostCreationDto postDto) {
      Post post = new Post{
        author = userId,
        content = postDto.content
      };
    }

    public Post GetById(int postId) {
      return context.Posts.Single(p => p.id == postId);
    }

    void Update(int postId, PostUpdateDto postDto) {
      Post post = GetById(postId);
      post.content = postDto.content;
      post.updated = DateTime.now;
      context.Posts.Update(post);
      context.SaveChanges();
    }

    void Delete(int postId) {
      Post post = GetById(postId);
      context.Posts.Remove(post);
      context.SaveChanges();
    }
  }
}
