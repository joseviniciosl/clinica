/*
               File: oObtieneExpediente
        Description: Obtiene Información de Expediente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:40.14
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
   public class oobtieneexpediente : GXProcedure
   {
      public oobtieneexpediente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtieneexpediente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ExpedienteId ,
                           ref DateTime aP2_ExpedienteFecha ,
                           ref String aP3_ExpedienteHora ,
                           ref String aP4_ExpedienteObs ,
                           ref short aP5_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A167ExpedienteId = aP1_ExpedienteId;
         this.AV8ExpedienteFecha = aP2_ExpedienteFecha;
         this.AV9ExpedienteHora = aP3_ExpedienteHora;
         this.AV10ExpedienteObs = aP4_ExpedienteObs;
         this.AV11Flag = aP5_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ExpedienteId=this.A167ExpedienteId;
         aP2_ExpedienteFecha=this.AV8ExpedienteFecha;
         aP3_ExpedienteHora=this.AV9ExpedienteHora;
         aP4_ExpedienteObs=this.AV10ExpedienteObs;
         aP5_Flag=this.AV11Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref int aP1_ExpedienteId ,
                               ref DateTime aP2_ExpedienteFecha ,
                               ref String aP3_ExpedienteHora ,
                               ref String aP4_ExpedienteObs )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A167ExpedienteId = aP1_ExpedienteId;
         this.AV8ExpedienteFecha = aP2_ExpedienteFecha;
         this.AV9ExpedienteHora = aP3_ExpedienteHora;
         this.AV10ExpedienteObs = aP4_ExpedienteObs;
         this.AV11Flag = aP5_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ExpedienteId=this.A167ExpedienteId;
         aP2_ExpedienteFecha=this.AV8ExpedienteFecha;
         aP3_ExpedienteHora=this.AV9ExpedienteHora;
         aP4_ExpedienteObs=this.AV10ExpedienteObs;
         aP5_Flag=this.AV11Flag;
         return AV11Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ExpedienteId ,
                                 ref DateTime aP2_ExpedienteFecha ,
                                 ref String aP3_ExpedienteHora ,
                                 ref String aP4_ExpedienteObs ,
                                 ref short aP5_Flag )
      {
         oobtieneexpediente objoobtieneexpediente;
         objoobtieneexpediente = new oobtieneexpediente();
         objoobtieneexpediente.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtieneexpediente.A167ExpedienteId = aP1_ExpedienteId;
         objoobtieneexpediente.AV8ExpedienteFecha = aP2_ExpedienteFecha;
         objoobtieneexpediente.AV9ExpedienteHora = aP3_ExpedienteHora;
         objoobtieneexpediente.AV10ExpedienteObs = aP4_ExpedienteObs;
         objoobtieneexpediente.AV11Flag = aP5_Flag;
         objoobtieneexpediente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtieneexpediente);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ExpedienteId=this.A167ExpedienteId;
         aP2_ExpedienteFecha=this.AV8ExpedienteFecha;
         aP3_ExpedienteHora=this.AV9ExpedienteHora;
         aP4_ExpedienteObs=this.AV10ExpedienteObs;
         aP5_Flag=this.AV11Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtieneexpediente)stateInfo).executePrivate();
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
         AV11Flag = 0 ;
         /* Using cursor P000G2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A168ExpedienteFecha = P000G2_A168ExpedienteFecha[0] ;
            A169ExpedienteHora = P000G2_A169ExpedienteHora[0] ;
            A176ExpedienteObs = P000G2_A176ExpedienteObs[0] ;
            AV8ExpedienteFecha = A168ExpedienteFecha ;
            AV9ExpedienteHora = A169ExpedienteHora ;
            AV10ExpedienteObs = A176ExpedienteObs ;
            AV11Flag = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
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
         P000G2_A41ClinicaCodigo = new String[] {""} ;
         P000G2_A167ExpedienteId = new int[1] ;
         P000G2_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         P000G2_A169ExpedienteHora = new String[] {""} ;
         P000G2_A176ExpedienteObs = new String[] {""} ;
         A168ExpedienteFecha = DateTime.MinValue ;
         A169ExpedienteHora = "" ;
         A176ExpedienteObs = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtieneexpediente__default(),
            new Object[][] {
                new Object[] {
               P000G2_A41ClinicaCodigo, P000G2_A167ExpedienteId, P000G2_A168ExpedienteFecha, P000G2_A169ExpedienteHora, P000G2_A176ExpedienteObs
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11Flag ;
      private int A167ExpedienteId ;
      private String AV9ExpedienteHora ;
      private String scmdbuf ;
      private String A169ExpedienteHora ;
      private DateTime AV8ExpedienteFecha ;
      private DateTime A168ExpedienteFecha ;
      private String A41ClinicaCodigo ;
      private String AV10ExpedienteObs ;
      private String A176ExpedienteObs ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ExpedienteId ;
      private DateTime aP2_ExpedienteFecha ;
      private String aP3_ExpedienteHora ;
      private String aP4_ExpedienteObs ;
      private short aP5_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P000G2_A41ClinicaCodigo ;
      private int[] P000G2_A167ExpedienteId ;
      private DateTime[] P000G2_A168ExpedienteFecha ;
      private String[] P000G2_A169ExpedienteHora ;
      private String[] P000G2_A176ExpedienteObs ;
   }

   public class oobtieneexpediente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000G2 ;
          prmP000G2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000G2", "SELECT [ClinicaCodigo], [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [ExpedienteObs] FROM [Expediente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] = @ExpedienteId ORDER BY [ClinicaCodigo], [ExpedienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G2,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
