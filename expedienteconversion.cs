/*
               File: ExpedienteConversion
        Description: Conversion for table Expediente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.99
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class expedienteconversion : GXProcedure
   {
      public expedienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public expedienteconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         expedienteconversion objexpedienteconversion;
         objexpedienteconversion = new expedienteconversion();
         objexpedienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objexpedienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((expedienteconversion)stateInfo).executePrivate();
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
         /* Using cursor EXPEDIENTE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A176ExpedienteObs = EXPEDIENTE2_A176ExpedienteObs[0] ;
            A4UsuarioCodigo = EXPEDIENTE2_A4UsuarioCodigo[0] ;
            A67PacienteId = EXPEDIENTE2_A67PacienteId[0] ;
            A169ExpedienteHora = EXPEDIENTE2_A169ExpedienteHora[0] ;
            A168ExpedienteFecha = EXPEDIENTE2_A168ExpedienteFecha[0] ;
            A167ExpedienteId = EXPEDIENTE2_A167ExpedienteId[0] ;
            A41ClinicaCodigo = EXPEDIENTE2_A41ClinicaCodigo[0] ;
            A40000GXC1 = EXPEDIENTE2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0046

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ExpedienteId = A167ExpedienteId ;
            AV4ExpedienteFecha = A168ExpedienteFecha ;
            AV5ExpedienteHora = A169ExpedienteHora ;
            AV6PacienteId = A67PacienteId ;
            AV7UsuarioCodigo = A4UsuarioCodigo ;
            AV8ExpedienteObs = A176ExpedienteObs ;
            /* Using cursor EXPEDIENTE3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ExpedienteId, AV4ExpedienteFecha, AV5ExpedienteHora, AV6PacienteId, AV7UsuarioCodigo, AV8ExpedienteObs});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
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
         EXPEDIENTE2_A176ExpedienteObs = new String[] {""} ;
         EXPEDIENTE2_A4UsuarioCodigo = new String[] {""} ;
         EXPEDIENTE2_A67PacienteId = new int[1] ;
         EXPEDIENTE2_A169ExpedienteHora = new String[] {""} ;
         EXPEDIENTE2_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         EXPEDIENTE2_A167ExpedienteId = new int[1] ;
         EXPEDIENTE2_A41ClinicaCodigo = new String[] {""} ;
         EXPEDIENTE2_A40000GXC1 = new int[1] ;
         A176ExpedienteObs = "" ;
         A4UsuarioCodigo = "" ;
         A169ExpedienteHora = "" ;
         A168ExpedienteFecha = DateTime.MinValue ;
         A41ClinicaCodigo = "" ;
         AV4ExpedienteFecha = DateTime.MinValue ;
         AV5ExpedienteHora = "" ;
         AV7UsuarioCodigo = "" ;
         AV8ExpedienteObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.expedienteconversion__default(),
            new Object[][] {
                new Object[] {
               EXPEDIENTE2_A176ExpedienteObs, EXPEDIENTE2_A4UsuarioCodigo, EXPEDIENTE2_A67PacienteId, EXPEDIENTE2_A169ExpedienteHora, EXPEDIENTE2_A168ExpedienteFecha, EXPEDIENTE2_A167ExpedienteId, EXPEDIENTE2_A41ClinicaCodigo, EXPEDIENTE2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A67PacienteId ;
      private int A167ExpedienteId ;
      private int A40000GXC1 ;
      private int GIGXA0046 ;
      private int AV2ClinicaCodigo ;
      private int AV3ExpedienteId ;
      private int AV6PacienteId ;
      private String scmdbuf ;
      private String A169ExpedienteHora ;
      private String AV5ExpedienteHora ;
      private String Gx_emsg ;
      private DateTime A168ExpedienteFecha ;
      private DateTime AV4ExpedienteFecha ;
      private String A176ExpedienteObs ;
      private String A4UsuarioCodigo ;
      private String A41ClinicaCodigo ;
      private String AV7UsuarioCodigo ;
      private String AV8ExpedienteObs ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] EXPEDIENTE2_A176ExpedienteObs ;
      private String[] EXPEDIENTE2_A4UsuarioCodigo ;
      private int[] EXPEDIENTE2_A67PacienteId ;
      private String[] EXPEDIENTE2_A169ExpedienteHora ;
      private DateTime[] EXPEDIENTE2_A168ExpedienteFecha ;
      private int[] EXPEDIENTE2_A167ExpedienteId ;
      private String[] EXPEDIENTE2_A41ClinicaCodigo ;
      private int[] EXPEDIENTE2_A40000GXC1 ;
   }

   public class expedienteconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmEXPEDIENTE2 ;
          prmEXPEDIENTE2 = new Object[] {
          } ;
          Object[] prmEXPEDIENTE3 ;
          prmEXPEDIENTE3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4ExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV5ExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV6PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV7UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8ExpedienteObs",SqlDbType.VarChar,600,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("EXPEDIENTE2", "SELECT [ExpedienteObs], [UsuarioCodigo], [PacienteId], [ExpedienteHora], [ExpedienteFecha], [ExpedienteId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Expediente] ORDER BY [ClinicaCodigo], [ExpedienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmEXPEDIENTE2,100,0,true,false )
             ,new CursorDef("EXPEDIENTE3", "INSERT INTO [GXA0046] ([ClinicaCodigo], [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [PacienteId], [UsuarioCodigo], [ExpedienteObs]) VALUES (@AV2ClinicaCodigo, @AV3ExpedienteId, @AV4ExpedienteFecha, @AV5ExpedienteHora, @AV6PacienteId, @AV7UsuarioCodigo, @AV8ExpedienteObs)", GxErrorMask.GX_NOMASK,prmEXPEDIENTE3)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
