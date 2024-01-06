namespace Taxe_PROFESSIONNELLE
{
    public static class FormData
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static int IdEtablisment { get; set; }
        public static int IdPeriode { get; set; }
        public static string IF { get; set; }
        public static string? nomPrenom { get; set; }
        public static string? cniCarte { get; set; }
        public static string? identifiantFiscal { get; set; }
        public static string? ice { get; set; }
        public static string? adress { get; set; }
        public static string? numTP { get; set; }
        public static string? numTSC { get; set; }
        public static bool declarationInitiale { get; set; }
        public static bool declarationModificative { get; set; }
        public static string? Annee { get; set; }
        public static string? adressLocaleDec { get; set; }
        public static string? numTPLocaleDec { get; set; }
        public static string? numTSCLocaleDec { get; set; }

        public static string? refNatureAcquision1 { get; set; }
        public static string? estImmatricule1 { get; set; }
        public static string? consistance1 { get; set; }
        public static string? superficie1 { get; set; }
        public static string? refStatutPatrimonial1 { get; set; }

        public static string? prixAcquision1 { get; set; }
        public static string? dateAcquisition1 { get; set; }
        public static string? refDesignationMat1 { get; set; }
        public static string? refEtatAcquision1 { get; set; }
        public static string? dateAcquision1 { get; set; }
        public static string? dateMiseEnService1 { get; set; }
        public static string? prixAcquisition1 { get; set; }
        
        public static string? designationRetrait1 { get; set; }
        public static string? natureOperationRetrait1 { get; set; }
        public static string? numFoncier { get; set; }
        public static string? dateAcquisition01 { get; set; }
        public static string? dateRetrait1 { get; set; }
        public static string? prixAcquisition01 { get; set; }
        public static string? prixCession1 { get; set; }
    }
}
