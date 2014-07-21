﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Security.Claims;
namespace System.IdentityModel.Test
{
    public static class Issuers
    {
        public const string GotJwt = @"http://www.GotJwt.com";
        public const string GotJwtOriginal = @"http://www.GotJwt.com/Original";
        public const string Actor = @"http://www.issuer.com";
        public const string ActorOriginal = @"http://www.issuer.com/Original";
    }

    public static class Audiences
    {
        public const string AuthFactors = @"http://www.AuthFactors.com";
        public const string Empty = "";
    }

    // TODO make these dynamic, as these are going to expire soon.
    public static class EncodedJwts
    {
        public static string Asymmetric_LocalSts =  @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpc3MiOiJodHRwOi8vR290Snd0LmNvbSIsImF1ZCI6Imh0dHA6Ly9Db250b3NvLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2NvdW50cnkiOiJVU0EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ1c2VyQGNvbnRvc28uY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiVG9ueSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2hvbWVwaG9uZSI6IjU1NS4xMjEyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiU2FsZXMiLCJzdWIiOiJib2IifQ.QW0Wfw-R5n3BHXE0vG-0giRFeB6W9oFrWJyFTaLI0qICDYx3yZ2eLXJ3zNFLVf3OG-MqytN5tqUdNfK1mRzeubqvdODHLFX36e1o3X8DR_YumyyQvgSeTJ0wwqT8PowbE3nbKfiX4TtJ4jffBelGKnL6vdx3AU2cwvLfSVp8ppA";
        public static string Asymmetric_1024 =      @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpc3MiOiJodHRwOi8vR290Snd0LmNvbSIsImF1ZCI6Imh0dHA6Ly9Db250b3NvLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2NvdW50cnkiOiJVU0EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ1c2VyQGNvbnRvc28uY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiVG9ueSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2hvbWVwaG9uZSI6IjU1NS4xMjEyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiU2FsZXMiLCJzdWIiOiJib2IifQ.WlNiBiAqmS4G-Em5O-uYiWLK5CJO8B-6Hvqjv_DXpoxldGiMWzivuyJocXPIIDVbcLxovmTc5j0KKgA9foOFBSkEEasqESA0VTYE30T1kkrGOaElola5DZagzax2zDipjxhbtBdMsvgF2t6GQJKyF0oFt828_yRGUsUnaXxg_MY";
        public static string Asymmetric_2048 =      @"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpc3MiOiJodHRwOi8vR290Snd0LmNvbSIsImF1ZCI6Imh0dHA6Ly9Db250b3NvLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2NvdW50cnkiOiJVU0EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ1c2VyQGNvbnRvc28uY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiVG9ueSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2hvbWVwaG9uZSI6IjU1NS4xMjEyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiU2FsZXMiLCJzdWIiOiJib2IifQ.XYeDHk0XRs1ybrk2AMWu3ZwNC6gPUYqxacJtUDSfQCGouRFdmkYtZcgvWAhH8iFv3DmPgfX0lI9WCtjN2JOZqOx5w90r9UKCh_9e_vUKZyjLkyUEv3iBl2HTpxfcj3ns5MmZI50N8O2cYq1d6-CRK_oi8oKhLWKfrD8LoMpCtV8zjraEB1GUfJvMrxPTIzHSF-V_nmu5aPIoHVyxAcc1jShkYdnS5Dz8nVqLBleCAQ2Tv-8N9Q8l1362b088y15auc-hBb76KmMU2aCutyJDRz0NqsCkFz-cV-vnIj-hzl562DzSUP48nEMTwEIO_bRKex1R5beZ36ZrKLP1GQxc8Q";
        public static string Symmetric_256   =      @"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vR290Snd0LmNvbSIsImF1ZCI6Imh0dHA6Ly9Db250b3NvLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2NvdW50cnkiOiJVU0EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJ1c2VyQGNvbnRvc28uY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiVG9ueSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2hvbWVwaG9uZSI6IjU1NS4xMjEyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiU2FsZXMiLCJzdWIiOiJib2IifQ._IFPA82MzKeV4IrsgZX8mkAEfzWT8-zEE4b5R2nzih4";
        public static string InvalidPayload =       @"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsIng1dCI6InZ4VThJR1pYdEFtemg0NzdDT05CR2dYRTlfYyJ9.eyJcdWQiOiJodHRwOi8vbG9jYWxob3N0L1JQIiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdC9TdHMiLCJuYmYiOjEzNjcyODA0MDUsImV4cCI6MTM2NzMwOTIwNSwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZ2l2ZW5uYW1lIjoiYWFsIn0.Pro66IUD94jvZNnG_l96Hph78L_LYSx6eobO6QfWF3y038ebLZorhKYgAj1LtsNVAbq7E_I5tnoI1Y4YUV5_wMGtMqT_XTB4N8vktDzf0Y32MhopsDrveofJAAFAUP1npYZtFF89RAWzy1GaXqXw05SbUcyMPWTSvmPk_frzJRTc-utAaBAp-zKqS1KXGB_s99x7lDxy3ZFMDFtFHQlOJiXeClXYCVkB-ZmvrSFSAIasFK4eIG9pOcMY43_wS7ybNjF7WncY6PEi6JmUoh2AwA-SCdY-Bhs80Tf4GMB2HsmuMkSVgoptt6Fgf-q8LhWG0W80g66JRgdhMj85BZ6bxg";
        public static string LiveJwt        =       @"eyJhbGciOiJIUzI1NiIsImtpZCI6IjAiLCJ0eXAiOiJKV1QifQ.eyJ2ZXIiOjEsImlzcyI6InVybjp3aW5kb3dzOmxpdmVpZCIsImV4cCI6MTM2ODY0ODg2MywidWlkIjoiMzgwZTE3YzMxNGU2ZmMyODA0NzA3MjI5NTc3MjEwZmIiLCJhdWQiOiJ3d3cuc3JpLWRldjEwMC5jb20iLCJ1cm46bWljcm9zb2Z0OmFwcHVyaSI6Im1zLWFwcDovL1MtMS0xNS0yLTM2MzczOTQzNzAtMjIzMTgyMTkzNi01NjUwMTU1MS0xNTE0NjEzNDgyLTQ1NjgzNjc4LTM1NzUyNjE4NTItMjMzNTgyNjkwIiwidXJuOm1pY3Jvc29mdDphcHBpZCI6IjAwMDAwMDAwNEMwRTdBNUMifQ.I-sE7t6IJUho1TfgaLilNuzro-pWOMgg33rQ351GcoM";

    }

    public static class Saml2SignedTokens
    {
        public static readonly string AAD_GotJWT = @"<Assertion ID='_775bef7d-0ba5-4df5-98f8-ec57f2b0cbef' IssueInstant='2013-04-11T20:02:45.903Z' Version='2.0' xmlns='urn:oasis:names:tc:SAML:2.0:assertion'><Issuer>https://sts.windows.net/d062b2b0-9aca-4ff7-b32a-ba47231a4002/</Issuer><ds:Signature xmlns:ds='http://www.w3.org/2000/09/xmldsig#'><ds:SignedInfo><ds:CanonicalizationMethod Algorithm='http://www.w3.org/2001/10/xml-exc-c14n#' /><ds:SignatureMethod Algorithm='http://www.w3.org/2001/04/xmldsig-more#rsa-sha256' /><ds:Reference URI='#_775bef7d-0ba5-4df5-98f8-ec57f2b0cbef'><ds:Transforms><ds:Transform Algorithm='http://www.w3.org/2000/09/xmldsig#enveloped-signature' /><ds:Transform Algorithm='http://www.w3.org/2001/10/xml-exc-c14n#' /></ds:Transforms><ds:DigestMethod Algorithm='http://www.w3.org/2001/04/xmlenc#sha256' /><ds:DigestValue>m1jXR5LORy7H+t+axtNauGnJakaKehvy0JhMZomZFrU=</ds:DigestValue></ds:Reference></ds:SignedInfo><ds:SignatureValue>IhaRBWAG/QeskVPO5Qa3EGN0A/bJ8qPqmJnuhox5F3aAGgqeoxbMhdwDMuQ7GC/7ScYDtYnAKATV6xP0nKTzwlqj1ltDEDN9scDuJIotwnV+xm4PCqlIeSZBHfyhIDp0rlhZDmhOnNy6+53FqVWMo7aSE1FdMCEh2aBgTRLH4jBkx5pKV0kQOX9D0Hq2GaV0LaXjcguADKxPpb1Gl+g8g/H/79n96fHAPITA8WygZjv1Satow87N8WK49n9qZJBWqmMjaVix6oFHPMOkp/qWE7ZhWKS1ANU2AwLMvZ8AH+RDwhWTWHnLCq2duD4XlCTRiY8juIn+zgJ51sfWQRYa2w==</ds:SignatureValue><KeyInfo xmlns='http://www.w3.org/2000/09/xmldsig#'><X509Data><X509Certificate>MIIDPjCCAiqgAwIBAgIQVWmXY/+9RqFA/OG9kFulHDAJBgUrDgMCHQUAMC0xKzApBgNVBAMTImFjY291bnRzLmFjY2Vzc2NvbnRyb2wud2luZG93cy5uZXQwHhcNMTIwNjA3MDcwMDAwWhcNMTQwNjA3MDcwMDAwWjAtMSswKQYDVQQDEyJhY2NvdW50cy5hY2Nlc3Njb250cm9sLndpbmRvd3MubmV0MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArCz8Sn3GGXmikH2MdTeGY1D711EORX/lVXpr+ecGgqfUWF8MPB07XkYuJ54DAuYT318+2XrzMjOtqkT94VkXmxv6dFGhG8YZ8vNMPd4tdj9c0lpvWQdqXtL1TlFRpD/P6UMEigfN0c9oWDg9U7Ilymgei0UXtf1gtcQbc5sSQU0S4vr9YJp2gLFIGK11Iqg4XSGdcI0QWLLkkC6cBukhVnd6BCYbLjTYy3fNs4DzNdemJlxGl8sLexFytBF6YApvSdus3nFXaMCtBGx16HzkK9ne3lobAwL2o79bP4imEGqg+ibvyNmbrwFGnQrBc1jTF9LyQX9q+louxVfHs6ZiVwIDAQABo2IwYDBeBgNVHQEEVzBVgBCxDDsLd8xkfOLKm4Q/SzjtoS8wLTErMCkGA1UEAxMiYWNjb3VudHMuYWNjZXNzY29udHJvbC53aW5kb3dzLm5ldIIQVWmXY/+9RqFA/OG9kFulHDAJBgUrDgMCHQUAA4IBAQAkJtxxm/ErgySlNk69+1odTMP8Oy6L0H17z7XGG3w4TqvTUSWaxD4hSFJ0e7mHLQLQD7oV/erACXwSZn2pMoZ89MBDjOMQA+e6QzGB7jmSzPTNmQgMLA8fWCfqPrz6zgH+1F1gNp8hJY57kfeVPBiyjuBmlTEBsBlzolY9dd/55qqfQk6cgSeCbHCy/RU/iep0+UsRMlSgPNNmqhj5gmN2AFVCN96zF694LwuPae5CeR2ZcVknexOWHYjFM0MgUSw0ubnGl0h9AJgGyhvNGcjQqu9vd1xkupFgaN+f7P3p3EVN5csBg5H94jEcQZT7EKeTiZ6bTrpDAnrr8tDCy8ng</X509Certificate></X509Data></KeyInfo></ds:Signature><Subject><NameID>X3hlFkILohbCj9c2Iib1NJg7e3hGhVsJdHuA7WRABp4</NameID><SubjectConfirmation Method='urn:oasis:names:tc:SAML:2.0:cm:bearer' /></Subject><Conditions NotBefore='2013-04-11T20:02:45.840Z' NotOnOrAfter='2013-04-12T08:02:45.840Z'><AudienceRestriction><Audience>https://localhost:44300/</Audience></AudienceRestriction></Conditions><AttributeStatement><Attribute Name='http://schemas.microsoft.com/identity/claims/objectidentifier'><AttributeValue>580e531c-87a4-415a-9f9d-6af51e2e1948</AttributeValue></Attribute><Attribute Name='http://schemas.microsoft.com/identity/claims/tenantid'><AttributeValue>d062b2b0-9aca-4ff7-b32a-ba47231a4002</AttributeValue></Attribute><Attribute Name='http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname'><AttributeValue>Got</AttributeValue></Attribute><Attribute Name='http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'><AttributeValue>GotJwt@GotJwt.onmicrosoft.com</AttributeValue></Attribute><Attribute Name='http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname'><AttributeValue>Jwt</AttributeValue></Attribute><Attribute Name='http://schemas.microsoft.com/identity/claims/identityprovider'><AttributeValue>https://sts.windows.net/d062b2b0-9aca-4ff7-b32a-ba47231a4002/</AttributeValue></Attribute></AttributeStatement><AuthnStatement AuthnInstant='2013-04-11T20:02:45.000Z'><AuthnContext><AuthnContextClassRef>urn:oasis:names:tc:SAML:2.0:ac:classes:Password</AuthnContextClassRef></AuthnContext></AuthnStatement></Assertion>";
    }

    public static class JsonClaims
    {
        public static readonly string GroupClaims = @"{""iss"":[""http://www.GotJWT.com"",""https://sts.windows.net/5803816d-c4ab-4601-a128-e2576e5d6910/""],""aud"":[""http://www.contoso.com"",""0bb44690-eae0-4b2c-b2b1-64ac03098226""],""upn"":""badams@dushyantgill.net"",""family_name"":""Adams"",""unique_name"":""badams@dushyantgill.net"",""ver"":""1.0"",""groups"":[""c4324023-3424-4ba6-9320-1ce28431b113"",""08953f81-ffd6-44f9-887d-69855355ffbd"",""694a55b2-ec4c-480d-8a7d-26d34ea9225b""],""oid"":""0c9545d0-a670-4628-8c1f-e90618a3b940"",""nonce"":""02f9c7ba-1720-4d46-b00f-6731fe2c4d14"",""given_name"":""Brad"",""exp"":1405870465,""tid"":""5803816d-c4ab-4601-a128-e2576e5d6910"",""iat"":""1403822988"",""amr"":""pwd"",""nbf"":1405866865,""sub"":""355anlmMo6uvGyabeIqNqBTUJsEPdyijxouLjfmg8G8""}";

        public static List<Claim> OverClaims(string issuer, string originalIssuer)
        {
            return new List<Claim>
            {
                new Claim("upn", "badams@dushyantgill.net", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("family_name", "Adams", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("unique_name", "badams@dushyantgill.net", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("ver", "1.0", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("aud", "0bb44690-eae0-4b2c-b2b1-64ac03098226", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("iss", "https://sts.windows-ppe.net/5803816d-c4ab-4601-a128-e2576e5d6910/", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("oid", "0c9545d0-a670-4628-8c1f-e90618a3b940", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_sources", @"{""src1"":{""endpoint"":""https://graph.windows.net/5803816d-c4ab-4601-a128-e2576e5d6910/users/0c9545d0-a670-4628-8c1f-e90618a3b940/getMemberObjects""}}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_sources", @"{""src2"":{""endpoint"":""https://graph.windows.net/5803816d-c4ab-4601-a128-e2576e5d6910/users/0c9545d0-a670-4628-8c1f-e90618a3b940/getMemberObjects""}}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_sources", @"{""src3"":{""endpoint"":""https://graph.windows.net/5803816d-c4ab-4601-a128-e2576e5d6910/users/0c9545d0-a670-4628-8c1f-e90618a3b940/getMemberObjects""}}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_names", @"{""groups"":""src1""}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_names", @"{""groups"":""src2""}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("_claim_names", @"{""groups"":""src3""}", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("nonce", "02f9c7ba-1720-4d46-b00f-6731fe2c4d14", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("given_name", "Brad", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("tid", "5803816d-c4ab-4601-a128-e2576e5d6910", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("iat", "1403822769", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("amr", @"[ ""pwd"" ]", ClaimValueTypes.String, issuer, originalIssuer),
                new Claim("sub", "355anlmMo6uvGyabeIqNqBTUJsEPdyijxouLjfmg8G8", ClaimValueTypes.String, issuer, originalIssuer),
            };
        }
    }
}