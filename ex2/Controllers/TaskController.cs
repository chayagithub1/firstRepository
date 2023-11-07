using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskManegerServise manegerServise;

        public TaskController(ITaskManegerServise manegerServise)
        {
            this.manegerServise = manegerServise;
        }

        // POST: TaskController/Create
        [HttpPost] 
        public void Create([FromBody]Task1 task)
        {
            manegerServise.CreateTask(task);
            return ;
            //return 4;
        }

        [HttpPut("updateTask")]
        public void Put(string title, [FromBody] Task1 t)
        {
            manegerServise.UpdateTask(title, t);
        }

        [HttpDelete("deleteTask")]
        public void Delete(string title)
        {
            manegerServise.DeleteTask(title);

        }





        //// GET: TaskController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TaskController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: TaskController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TaskController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
