/*
               File: pEliminaReceta
        Description: Elimina Registro de Recetas del Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:36.98
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
   public class peliminareceta : GXProcedure
   {
      public peliminareceta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public peliminareceta( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId ,
                           ref int aP2_RecetaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8RecetaId = aP2_RecetaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaId=this.AV8RecetaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo ,
                             ref int aP1_ConsultaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8RecetaId = aP2_RecetaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaId=this.AV8RecetaId;
         return AV8RecetaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId ,
                                 ref int aP2_RecetaId )
      {
         peliminareceta objpeliminareceta;
         objpeliminareceta = new peliminareceta();
         objpeliminareceta.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpeliminareceta.A91ConsultaId = aP1_ConsultaId;
         objpeliminareceta.AV8RecetaId = aP2_RecetaId;
         objpeliminareceta.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpeliminareceta);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaId=this.AV8RecetaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((peliminareceta)stateInfo).executePrivate();
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
         /* Optimized DELETE. */
         /* Using cursor P00082 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId, AV8RecetaId});
         pr_default.close(0);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pEliminaReceta");
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.peliminareceta__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A91ConsultaId ;
      private int AV8RecetaId ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private int aP2_RecetaId ;
      private IDataStoreProvider pr_default ;
   }

   public class peliminareceta__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00082 ;
          prmP00082 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8RecetaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00082", "DELETE FROM [Receta]  WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId and [RecetaId] = @AV8RecetaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00082)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
