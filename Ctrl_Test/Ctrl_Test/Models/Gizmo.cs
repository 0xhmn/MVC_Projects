using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Ctrl_Test.Models
{
    public class Gizmo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime IntroducedDate { get; set; }
        public int Quantity { get; set; }
    }

    public class GizmoService
    {
        // sync get
        public List<Gizmo> GetGizmos()
        {
            var gizmoList = new List<Gizmo>
            {
                new Gizmo {Id = 1, IntroducedDate = DateTime.Today, Name = "First Gizmo", Quantity = 10},
                new Gizmo {Id = 2, IntroducedDate = DateTime.Today, Name = "<script>alert('second name with alert');</script>", Quantity = 5}
            };
            return gizmoList;
        } 


        ///<summary>
        /// ASYNC STUFF
        /// </summary>

        // making a list after two seconds
        private List<Gizmo> MakeListAfterTwoSeconds()
        {
            Thread.Sleep(6000);
            var gizmoList = new List<Gizmo>
            {
                new Gizmo {Id = 1, IntroducedDate = DateTime.Today, Name = "First Gizmo", Quantity = 10},
                new Gizmo {Id = 2, IntroducedDate = DateTime.Today, Name = "Second Gizmo", Quantity = 5}
            };
            return gizmoList;
        }

        // make a task
        private Task<List<Gizmo>> MakeListAfterTwoSecondsAsync()
        {
            return Task.Factory.StartNew(() => MakeListAfterTwoSeconds());
        }

        // async get
        public async Task<List<Gizmo>> GetGizmosAsync()
        {
            return await MakeListAfterTwoSecondsAsync();
        } 
    }
}