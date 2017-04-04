//using System;
//using System.Collections;
//using System.Linq;
//using Inventory.DAL;
//using System.Collections.Generic;

//namespace Inventory.BLL
//{
//    public class InventoryDataChanger
//    {
//        InventoryContext ic;

//        public InventoryDataChanger(InventoryContext context)
//        {
//            ic = context;
//        }
//        #region MakerManipulation

//        public void MakerAddNew(Maker newMaker)
//        {
//            ic.Makers.Add(newMaker);
//            ic.SaveChanges();
//        }
//        public void MakerSelect()
//        {
//            var makers = from m in ic.Makers
//                         select m;
//            foreach (Maker maker in makers)
//            {
//                Console.WriteLine(maker.ID + "\t" + maker.Name);
//            }
//        }
//        public Maker MakerSelectByname(string name)
//        {
//            Maker select = new DAL.Maker();
//            var maker = (from m in ic.Makers
//                         where m.Name == name
//                         select m).ToList();
//            foreach (Maker m in maker)
//            {
//                select=m;
//            }
//            return select;
//        }
//        public void MakerUpdate(string makerName, string newMakerName)
//        {

//            try
//            {

//                var maker = ic.Makers.
//                Where(m => m.Name == makerName).
//                FirstOrDefault();
//                //Change vlaue
//                maker.Name = newMakerName;
//                ic.SaveChanges();

//            }
//            catch (NullReferenceException ex)
//            {
//                Console.WriteLine("Value doesn't exist in current context", ex.Message);
//            }
//        }
//        #endregion

//        #region Modelmanipulation
//        public void MakerAddNew(Model model)
//        {
//            ic.Models.Add(model);
//            ic.SaveChanges();
//        }
//        public IEnumerable<Model> ModelSelect()
//        {
//            var models = (from md in ic.Models
//                          select md).
//                         AsEnumerable<Model>();

//            IEnumerable<Model> modelsList = models;
//            return modelsList;
//        }
//        public void ModelInsert(Model model)
//        {

//            try
//            {
//                ic.Models.Add(model);
//                ic.SaveChanges();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }//TODO: methods for Model
//        #endregion
//        #region TypeEquipment manipulation
//        public EqType EqTypeSelectByname(string name)
//        {
//            EqType select = new DAL.EqType();
//            var eqtype = (from e in ic.EqTypes
//                         where e.Name == name
//                         select e).ToList();
//            foreach (EqType e in eqtype)
//            {
//                select = e;
//            }
//            return select;
//        }
//        #endregion
//    }

//}
