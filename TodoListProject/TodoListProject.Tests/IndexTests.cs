using Microsoft.AspNetCore.Mvc;
using Moq;
using TodoListProject.Repo;
using TodoListProject.Pages;

namespace TodoListProject.Tests
{
    public class IndexTests
    {
        private Mock<ITodoRepo> _mockRepo;
        private TodoListProject.Pages.IndexModel _sut;
        public IndexTests() 
        {
            _mockRepo = new Mock<ITodoRepo>();
           // _sut = new TodoListProject.Pages.IndexModel(_mockRepo.Object);
        }

        [Fact]
        public async void OnPost_ValidModel_RepoCalledAndRedirect()
        {
          //  _sut.NewTodo = new Todo(false, DateTime.Now, "test");
            var result = await _sut.OnPost();

            Assert.IsType<RedirectToPageResult>(result);
          //  _mockRepo.Verify(x => x.AddAsync(It.IsAny<Todo>()));
          //  _mockRepo.Verify(x => x.GetAllAsync(), Times.AtMostOnce());
        }
    }
}