/*
               File: MedicoConversion
        Description: Conversion for table Medico
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.36
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
   public class medicoconversion : GXProcedure
   {
      public medicoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public medicoconversion( IGxContext context )
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
         medicoconversion objmedicoconversion;
         objmedicoconversion = new medicoconversion();
         objmedicoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objmedicoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((medicoconversion)stateInfo).executePrivate();
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
         /* Using cursor MEDICOCONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A25MedicoCorreo = MEDICOCONV2_A25MedicoCorreo[0] ;
            A24MedicoTelefono2 = MEDICOCONV2_A24MedicoTelefono2[0] ;
            A23MedicoTelefono1 = MEDICOCONV2_A23MedicoTelefono1[0] ;
            A22MedicoDireccion = MEDICOCONV2_A22MedicoDireccion[0] ;
            A21MedicoColegiado = MEDICOCONV2_A21MedicoColegiado[0] ;
            A20MedicoNombre = MEDICOCONV2_A20MedicoNombre[0] ;
            A19MedicoCodigo = MEDICOCONV2_A19MedicoCodigo[0] ;
            A41ClinicaCodigo = MEDICOCONV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = MEDICOCONV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0008

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3MedicoCodigo = A19MedicoCodigo ;
            AV4MedicoNombre = A20MedicoNombre ;
            AV5MedicoColegiado = A21MedicoColegiado ;
            AV6MedicoDireccion = A22MedicoDireccion ;
            AV7MedicoTelefono1 = A23MedicoTelefono1 ;
            AV8MedicoTelefono2 = A24MedicoTelefono2 ;
            AV9MedicoCorreo = A25MedicoCorreo ;
            /* Using cursor MEDICOCONV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3MedicoCodigo, AV4MedicoNombre, AV5MedicoColegiado, AV6MedicoDireccion, AV7MedicoTelefono1, AV8MedicoTelefono2, AV9MedicoCorreo});
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
         MEDICOCONV2_A25MedicoCorreo = new String[] {""} ;
         MEDICOCONV2_A24MedicoTelefono2 = new String[] {""} ;
         MEDICOCONV2_A23MedicoTelefono1 = new String[] {""} ;
         MEDICOCONV2_A22MedicoDireccion = new String[] {""} ;
         MEDICOCONV2_A21MedicoColegiado = new String[] {""} ;
         MEDICOCONV2_A20MedicoNombre = new String[] {""} ;
         MEDICOCONV2_A19MedicoCodigo = new String[] {""} ;
         MEDICOCONV2_A41ClinicaCodigo = new String[] {""} ;
         MEDICOCONV2_A40000GXC1 = new int[1] ;
         A25MedicoCorreo = "" ;
         A24MedicoTelefono2 = "" ;
         A23MedicoTelefono1 = "" ;
         A22MedicoDireccion = "" ;
         A21MedicoColegiado = "" ;
         A20MedicoNombre = "" ;
         A19MedicoCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3MedicoCodigo = "" ;
         AV4MedicoNombre = "" ;
         AV5MedicoColegiado = "" ;
         AV6MedicoDireccion = "" ;
         AV7MedicoTelefono1 = "" ;
         AV8MedicoTelefono2 = "" ;
         AV9MedicoCorreo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.medicoconversion__default(),
            new Object[][] {
                new Object[] {
               MEDICOCONV2_A25MedicoCorreo, MEDICOCONV2_A24MedicoTelefono2, MEDICOCONV2_A23MedicoTelefono1, MEDICOCONV2_A22MedicoDireccion, MEDICOCONV2_A21MedicoColegiado, MEDICOCONV2_A20MedicoNombre, MEDICOCONV2_A19MedicoCodigo, MEDICOCONV2_A41ClinicaCodigo, MEDICOCONV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0008 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A25MedicoCorreo ;
      private String A24MedicoTelefono2 ;
      private String A23MedicoTelefono1 ;
      private String A22MedicoDireccion ;
      private String A21MedicoColegiado ;
      private String A20MedicoNombre ;
      private String A19MedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3MedicoCodigo ;
      private String AV4MedicoNombre ;
      private String AV5MedicoColegiado ;
      private String AV6MedicoDireccion ;
      private String AV7MedicoTelefono1 ;
      private String AV8MedicoTelefono2 ;
      private String AV9MedicoCorreo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] MEDICOCONV2_A25MedicoCorreo ;
      private String[] MEDICOCONV2_A24MedicoTelefono2 ;
      private String[] MEDICOCONV2_A23MedicoTelefono1 ;
      private String[] MEDICOCONV2_A22MedicoDireccion ;
      private String[] MEDICOCONV2_A21MedicoColegiado ;
      private String[] MEDICOCONV2_A20MedicoNombre ;
      private String[] MEDICOCONV2_A19MedicoCodigo ;
      private String[] MEDICOCONV2_A41ClinicaCodigo ;
      private int[] MEDICOCONV2_A40000GXC1 ;
   }

   public class medicoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmMEDICOCONV2 ;
          prmMEDICOCONV2 = new Object[] {
          } ;
          Object[] prmMEDICOCONV3 ;
          prmMEDICOCONV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4MedicoNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5MedicoColegiado",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6MedicoDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV7MedicoTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV8MedicoTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV9MedicoCorreo",SqlDbType.VarChar,80,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("MEDICOCONV2", "SELECT [MedicoCorreo], [MedicoTelefono2], [MedicoTelefono1], [MedicoDireccion], [MedicoColegiado], [MedicoNombre], [MedicoCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Medico] ORDER BY [ClinicaCodigo], [MedicoCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmMEDICOCONV2,100,0,true,false )
             ,new CursorDef("MEDICOCONV3", "INSERT INTO [GXA0008] ([ClinicaCodigo], [MedicoCodigo], [MedicoNombre], [MedicoColegiado], [MedicoDireccion], [MedicoTelefono1], [MedicoTelefono2], [MedicoCorreo]) VALUES (@AV2ClinicaCodigo, @AV3MedicoCodigo, @AV4MedicoNombre, @AV5MedicoColegiado, @AV6MedicoDireccion, @AV7MedicoTelefono1, @AV8MedicoTelefono2, @AV9MedicoCorreo)", GxErrorMask.GX_NOMASK,prmMEDICOCONV3)
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                break;
       }
    }

 }

}
