/*
               File: DPSlideDownMenuData
        Description: DPSlide Down Menu Data
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:32.33
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class dpslidedownmenudata : GXProcedure
   {
      public dpslidedownmenudata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public dpslidedownmenudata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_GrupoCodigo ,
                           out IGxCollection aP1_Gxm2rootcol )
      {
         this.A1GrupoCodigo = aP0_GrupoCodigo;
         this.Gxm2rootcol = new GxObjectCollection( context, "SlideDownMenuData.SlideDownMenuDataItem", "Clinica", "SdtSlideDownMenuData_SlideDownMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( String aP0_GrupoCodigo )
      {
         this.A1GrupoCodigo = aP0_GrupoCodigo;
         this.Gxm2rootcol = new GxObjectCollection( context, "SlideDownMenuData.SlideDownMenuDataItem", "Clinica", "SdtSlideDownMenuData_SlideDownMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP1_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( String aP0_GrupoCodigo ,
                                 out IGxCollection aP1_Gxm2rootcol )
      {
         dpslidedownmenudata objdpslidedownmenudata;
         objdpslidedownmenudata = new dpslidedownmenudata();
         objdpslidedownmenudata.A1GrupoCodigo = aP0_GrupoCodigo;
         objdpslidedownmenudata.Gxm2rootcol = new GxObjectCollection( context, "SlideDownMenuData.SlideDownMenuDataItem", "Clinica", "SdtSlideDownMenuData_SlideDownMenuDataItem", "GeneXus.Programs") ;
         objdpslidedownmenudata.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objdpslidedownmenudata);
         aP1_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((dpslidedownmenudata)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P00012 */
         pr_default.execute(0, new Object[] {A1GrupoCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A15MenuAcceso = P00012_A15MenuAcceso[0] ;
            A9MenuDescripcion = P00012_A9MenuDescripcion[0] ;
            A8MenuId = P00012_A8MenuId[0] ;
            A9MenuDescripcion = P00012_A9MenuDescripcion[0] ;
            Gxm1slidedownmenudata = new SdtSlideDownMenuData_SlideDownMenuDataItem(context) ;
            Gxm2rootcol.Add(Gxm1slidedownmenudata, 0);
            Gxm1slidedownmenudata.gxTpr_Parentid = (short)(A8MenuId) ;
            Gxm1slidedownmenudata.gxTpr_Parenttitle = A9MenuDescripcion ;
            Gxm1slidedownmenudata.gxTpr_Parentdescription = A9MenuDescripcion ;
            AV6MenuId = AV5MenuId ;
            AV5MenuId = A8MenuId ;
            /* Execute user subroutine: S1114 */
            S1114 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV5MenuId = AV6MenuId ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S1114( )
      {
         /* Sub4items Routine */
         /* Using cursor P00013 */
         pr_default.execute(1, new Object[] {A1GrupoCodigo, AV5MenuId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A16OpcionAcceso = P00013_A16OpcionAcceso[0] ;
            A8MenuId = P00013_A8MenuId[0] ;
            A12OpcionDescripcion = P00013_A12OpcionDescripcion[0] ;
            A13OpcionObjeto = P00013_A13OpcionObjeto[0] ;
            A11OpcionId = P00013_A11OpcionId[0] ;
            A12OpcionDescripcion = P00013_A12OpcionDescripcion[0] ;
            A13OpcionObjeto = P00013_A13OpcionObjeto[0] ;
            Gxm5slidedownmenudata_sections = new SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem(context) ;
            Gxm1slidedownmenudata.gxTpr_Sections.Add(Gxm5slidedownmenudata_sections, 0);
            Gxm5slidedownmenudata_sections.gxTpr_Sectionid = (short)(A11OpcionId) ;
            Gxm5slidedownmenudata_sections.gxTpr_Sectiontitle = A12OpcionDescripcion ;
            Gxm5slidedownmenudata_sections.gxTpr_Sectiondescription = A12OpcionDescripcion ;
            Gxm5slidedownmenudata_sections.gxTpr_Sectionurl = StringUtil.Trim( A13OpcionObjeto) ;
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P00012_A1GrupoCodigo = new String[] {""} ;
         P00012_A15MenuAcceso = new short[1] ;
         P00012_A9MenuDescripcion = new String[] {""} ;
         P00012_A8MenuId = new int[1] ;
         A9MenuDescripcion = "" ;
         Gxm1slidedownmenudata = new SdtSlideDownMenuData_SlideDownMenuDataItem(context);
         P00013_A1GrupoCodigo = new String[] {""} ;
         P00013_A16OpcionAcceso = new short[1] ;
         P00013_A8MenuId = new int[1] ;
         P00013_A12OpcionDescripcion = new String[] {""} ;
         P00013_A13OpcionObjeto = new String[] {""} ;
         P00013_A11OpcionId = new int[1] ;
         A12OpcionDescripcion = "" ;
         A13OpcionObjeto = "" ;
         Gxm5slidedownmenudata_sections = new SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.dpslidedownmenudata__default(),
            new Object[][] {
                new Object[] {
               P00012_A1GrupoCodigo, P00012_A15MenuAcceso, P00012_A9MenuDescripcion, P00012_A8MenuId
               }
               , new Object[] {
               P00013_A1GrupoCodigo, P00013_A16OpcionAcceso, P00013_A8MenuId, P00013_A12OpcionDescripcion, P00013_A13OpcionObjeto, P00013_A11OpcionId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A15MenuAcceso ;
      private short A16OpcionAcceso ;
      private int A8MenuId ;
      private int AV6MenuId ;
      private int AV5MenuId ;
      private int A11OpcionId ;
      private String scmdbuf ;
      private bool returnInSub ;
      private String A1GrupoCodigo ;
      private String A9MenuDescripcion ;
      private String A12OpcionDescripcion ;
      private String A13OpcionObjeto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00012_A1GrupoCodigo ;
      private short[] P00012_A15MenuAcceso ;
      private String[] P00012_A9MenuDescripcion ;
      private int[] P00012_A8MenuId ;
      private String[] P00013_A1GrupoCodigo ;
      private short[] P00013_A16OpcionAcceso ;
      private int[] P00013_A8MenuId ;
      private String[] P00013_A12OpcionDescripcion ;
      private String[] P00013_A13OpcionObjeto ;
      private int[] P00013_A11OpcionId ;
      private IGxCollection aP1_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtSlideDownMenuData_SlideDownMenuDataItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtSlideDownMenuData_SlideDownMenuDataItem Gxm1slidedownmenudata ;
      private SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem Gxm5slidedownmenudata_sections ;
   }

   public class dpslidedownmenudata__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00013 ;
          prmP00013 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV5MenuId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT T1.[GrupoCodigo], T1.[MenuAcceso], T2.[MenuDescripcion], T1.[MenuId] FROM ([AccesoMenu] T1 WITH (NOLOCK) INNER JOIN [Menu] T2 WITH (NOLOCK) ON T2.[MenuId] = T1.[MenuId]) WHERE (T1.[GrupoCodigo] = @GrupoCodigo) AND (T1.[MenuAcceso] = 1) ORDER BY T1.[GrupoCodigo], T1.[MenuId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00013", "SELECT T1.[GrupoCodigo], T1.[OpcionAcceso], T1.[MenuId], T2.[OpcionDescripcion], T2.[OpcionObjeto], T1.[OpcionId] FROM ([AccesoOpcion] T1 WITH (NOLOCK) INNER JOIN [Opcion] T2 WITH (NOLOCK) ON T2.[MenuId] = T1.[MenuId] AND T2.[OpcionId] = T1.[OpcionId]) WHERE (T1.[GrupoCodigo] = @GrupoCodigo and T1.[MenuId] = @AV5MenuId) AND (T1.[OpcionAcceso] = 1) ORDER BY T1.[GrupoCodigo], T1.[MenuId], T1.[OpcionId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00013,100,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
