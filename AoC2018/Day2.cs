using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2018
{
    class Day2
    {
        public void Day2Task1()
        {
            string origInput = "cvfueihajytpmrdkgsxfqplbxn,cbzueihajytnmrdkgtxfqplbwn,cvzucihajytomrdkgstfqplqwn,cvzueilajytomrdkgsxfqwnbwn,cvzueihajytomrdkgsgwqphbwn,wuzuerhajytomrdkgsxfqplbwn,cyzueifajybomrdkgsxfqplbwn,cvzueihajxtomrdkgpxfqplmwn,ivzfevhajytomrdkgsxfqplbwn,cvzueihajytomrdlgsxfqphbbn,uvzueihajjtomrdkgsxfqpobwn,cvzupihajytomrdkgsxfqplpwe,cvzueihajyvomrdkgsxfqplbrl,cczueihajytomrdkgsnfqpxbwn,cvzueigajytdmrdkgsxyqplbwn,cvzujihljytomrdkgsxuqplbwn,cvzueisajytomrddgsxkqplbwn,cvzneihajytomrdkgsgaqplbwn,cvzueihajytomrdkgsinmplbwn,cveueihajyromrdkgsxfqplown,cypueihajytotrdkgzxfqplbwn,cvzuoihajytomvdqgsxfqplbwn,cvzuekhejytwmrdkgsxfqplbwn,cvzseihajytomrdkgsxfqgmbwn,cvfuhihajytomrdkgsxfqplbwi,cvzueihujxtomrdkgsufqplbwn,cvzueihdjytomrdogsxfqplbwh,cvzueihdjyfohrdkgsxfqplbwn,cvtudihajytolrdkgsxfqplbwn,cvzueihajytymrdkgshzqplbwn,cvzuebhajytomxdkgsxfqplbwt,cvzulihajyxomrdkgsbfqplbwn,cvzueihajywomrdkgsxfqplbts,cvzueihajytouodkdsxfqplbwn,cvzueihajytomgdkgqxfqklbwn,cvzubihajytomvdkgsxfqplmwn,cvhueihajyyocrdkgsxfqplbwn,zvzueihajytourdkgsxflplbwn,cvzbeihajytomadkgsxfoplbwn,cvzueihajytomrdkgnxfqplbsl,cvfueihajftkmrdkgsxfqplbwn,cvzuexhajytomryugsxfqplbwn,cvzueihajytomsckgsxfqalbwn,cvzuexhajytomrdkbsxfqpluwn,cvzueihajytbmrtkgsxwqplbwn,cvzueihajytomrdigsxfqqlbsn,cvzweihajytomydkgsxfmplbwn,bvzteihajytimrdkgsxfqplbwn,cvzueihajytpmrdkgsxfcpbbwn,cvzueigsjltomrdkgsxfqplbwn,cvzueihajytomrikgsxfopldwn,cvzueihajstomrdkgsxfqplgon,cvzueimajytomrnkxsxfqplbwn,cvzleihagatomrdkgsxfqplbwn,cvbueihajotomrdkgsxfqjlbwn,cvzueihajytomrdkgsxfqppnvn,hvzueihajytomrdkghxfkplbwn,cvzueigajytxmrdkgsxfqplbjn,cvzueihaaxtokrdkgsxfqplbwn,cvzueihajyeomrdkgujfqplbwn,cvzueiwajpoomrdkgsxfqplbwn,cvzieidtjytomrdkgsxfqplbwn,cvzueihalytomrakbsxfqplbwn,wtzueihajytomrdkgsxfqplbwq,cvzuelhaiytomrdkgsxfqplcwn,cvzueihajytomrdkgsxfqslswd,cvzueihajytomrykgssfqplbon,cvzueihfjytovrdegsxfqplbwn,cvzueihajytomldqgsxfqplbwy,cvzleihjjytomrtkgsxfqplbwn,cvzueihaldtomrdtgsxfqplbwn,cvzueihajytzmrdkgsxfeplqwn,cvzueihrjytomddkgsxfqpgbwn,cyzulihajytokrdkgsxfqplbwn,cvsueihajytoordfgsxfqplbwn,fvzueyhajytomrdkgaxfqplbwn,cczueihajytobrdkgsefqplbwn,cvzueihajytomcdrgscfqplbwn,cvzuexhajyvomrdkgssfqplbwn,cvzsmihajyiomrdkgsxfqplbwn,cvzzeihajttomrdkgsxzqplbwn,cvzseihajytomrdkgsxfqpebvn,cvzueihajgthmrdkgsbfqplbwn,ruzueihajytomrdkgsxfqphbwn,cvzueihajytofrdkgsnfrplbwn,cvzuetdajytojrdkgsxfqplbwn,fvzueihajytomrdkghxfqpobwn,cvzueihsjytomrdkgsxfqglbxn,cvzueihajytowrdkgsxfqpsbun,cvzteihaiytomrdkfsxfqplbwn,cvzueihajytkmrdkrsxfqplvwn,cvzueihajyoomrdkasxfqjlbwn,lvzurihajytkmrdkgsxfqplbwn,cvzueihajyyomrdagsxfqelbwn,cvfueihajytomrdkgsxfqplbbx,cvwueihajytommdkgkxfqplbwn,cvzucicajytomrdkgsxcqplbwn,dvzueihahytgmrdkgsxfqplbwn,cvzuechajytomrdkgsxfqelwwn,cvzuekhajytomrdkgsxknplbwn,cvtueihajytomphkgsxfqplbwn,cvzueihabytnzrdkgsxfqplbwn,cvzusihajytomrdkgfxfqplban,cvfueihajytomcdfgsxfqplbwn,mvzueihapytomrdkgsxfdplbwn,cvzueihajytomhdkgsxmqppbwn,jvsueihajytomrdkgsxfqplbln,cvzujihajybomrdkgsxtqplbwn,cvzuekhawytomrdkgsxfqplbwc,svzueihanytomrdogsxfqplbwn,cvzujihajytodrdkgslfqplbwn,cvgdeihajytorrdkgsxfqplbwn,cvzbeihajytoprdkgsxfqplbyn,cvzueihkyytomjdkgsxfqplbwn,cvzuelhojytomrdkgsxfqjlbwn,evzueihajytimrdkgsxfqpsbwn,cvzueihajydomrdkjsxfqplbjn,ovzteihajytosrdkgsxfqplbwn,cvzueihajyaomrdzgsxfqplbgn,cvzuewhajmtomrdkgsufqplbwn,cvzueihajqtomhukgsxfqplbwn,cvzueihajytomzqkgsxfqplbwk,cazuewhakytomrdkgsxfqplbwn,clzueihatytomrdkgzxfqplbwn,dvzueihajytomqdkgsxfqpnbwn,cvzueidajdtomrdkgsxtqplbwn,cvzueihabytowrdkgsxoqplbwn,cvzujihwjytomrdkgsxeqplbwn,cvtuedhajytomrdkgsxfqplbbn,cvzueihajcgomrdkgsxfqplswn,cvzuephajyiomrdngsxfqplbwn,cvzueihajythmqdkgsxfqplbwf,cvzueitajytomrdkgsxfepvbwn,cvzueihajytomydkgsxfqplvwb,dvzueshajytomrddgsxfqplbwn,cvzueihajytomrdkgvxfqpwben,cvzueihajytomrdkgvxfpplwwn,cvzuefhajftomrdkgsxfqrlbwn,cvzueihajytpmrvkgsxfqplbcn,cvzueihajytohrdkgsxfqxnbwn,cvzueihajytomrdposxfqulbwn,cozueihajytomrpkgsxfqrlbwn,cvzuuihaxytomrdkgsxfqplbtn,cvzueihajytomrbzgsxyqplbwn,cveueihajyxoqrdkgsxfqplbwn,cvzueihajytomrkkgsxfqptbrn,cvzuezhajatomrdkssxfqplbwn,cpzueihajytomrdkgsxfhplbwo,lviueihajytomrekgsxfqplbwn,cvzueihwjytomrdkusxfyplbwn,cvzgeihajytomwdkgsxfrplbwn,cvzsejhzjytomrdkgsxfqplbwn,cvzuuihajytomrdkgsxfqdlbwz,cvzjeihajytomrdugsxftplbwn,cvzueihaxytomrrkgsxfmplbwn,cvzueihajgtomrdhgsxfqplwwn,cvzulihajytomedkgsxfqplewn,cvzueivajytomrdkmsxfqplbwc,cvzuervajytomrdkgsxfwplbwn,cvzuemhcjytomrdkgslfqplbwn,cvzyerhauytomrdkgsxfqplbwn,cvzueihaoytomrdkgsyfqplewn,cvzueihanytomrdkgsafkplbwn,cvzueihajvtomrdugsxfqpcbwn,chzueihajytamrdxgsxfqplbwn,cvzueihalytomrdsgsxfqplbln,cvzueihajytoyaykgsxfqplbwn,tlzueihajyeomrdkgsxfqplbwn,cvpueihajytbmrdkgsxfxplbwn,cvzueihajytomjdkgsxuqplkwn,cvzueihajygomrdkgkxfqplbwg,cvzueihajhtomrdkgbxsqplbwn,cvzurihajytomrdkgsafqplbwx,cdzuezhajytomrdkgsxrqplbwn,cvbueihajytotrwkgsxfqplbwn,cwzkeihajytomrdkgsxfqplbwh,cvzheihajytolrikgsxfqplbwn,cozuevhajytomrdkgkxfqplbwn,chzueihajytomrjkgsxfqulbwn,cvzueihkjyromrdkgsxvqplbwn,cvzveihajytomrdkgsxpqplnwn,cvzueihajytoirdkgsxfqihbwn,cvoueihajytomrdkgsxfqpdawn,pvzueihajytomrdkgnxfqplbfn,cvzueihakytomxdkgssfqplbwn,cvzueivajytomrdbgsxaqplbwn,cvzueihajytokrdkgszrqplbwn,cvzuevhajytomrdkgsxgqplbwi,cvzueihajylomrdkgsxflplbpn,hvzueihajytomvdkgsxfqplgwn,cvzleihajytymrrkgsxfqplbwn,crzueieajytomrdkgsxfqplbon,cszueihajytomrdlgqxfqplbwn,cvzueihacytomrdkgsxfjblbwn,cvzreihajytomrdkgsxfqplzun,cvzurihajytomrdkgsxiqplawn,uvzueihajyhovrdkgsxfqplbwn,cvzueihajyqodrdkgssfqplbwn,cvzwiihrjytomrdkgsxfqplbwn,cqzueihajytomrdkgjxfqplban,cvmueihajytoordkgsxfqplbyn,cypueihajytomrdkgzxfqplbwn,cvzueihajykomrdkgsmfqplbtn,cvzueidajytimrdkgsxfqpdbwn,cvzheihajytomrdkgsxfqpfewn,dvzueihajytumrdzgsxfqplbwn,cvzueixajytomrdkgsvfqplgwn,cvzuevhzjyzomrdkgsxfqplbwn,cvyeeihajytomrdkgsxnqplbwn,cvzueihajytomrdkggtpqplbwn,cvzceiyajytomrdkgexfqplbwn,cvzuelhajyyomrdkzsxfqplbwn,cvzhzihajygomrdkgsxfqplbwn,cvzueihwjytomrdkgsgfqplbrn,cvzsevhajytomrdkgqxfqplbwn,cvzueiuajytomrdkgsxfppebwn,nvzueihajytemrdkgsxwqplbwn,cvzueihajytocgdkgsxfqvlbwn,cczusihajytomrdkgsxfqplbpn,cmzueihajytomrdkbsxwqplbwn,cvzumfdajytomrdkgsxfqplbwn,cvzueihcjytomrdkgsxfqplbkl,cvzueihajytomawknsxfqplbwn,kvzueihijytomrdkgsxdqplbwn,cdzutihajytomrdkgsxfkplbwn,cvzufihadylomrdkgsxfqplbwn,cvzueihajytomrgkxsxfqphbwn,cvzuewhajyzomrdkgsxfqelbwn,cvzueihajytomrdkgqxfqelbwc,cvzueshajyoomrdkgsxfqflbwn,cvzueihajyromrekgixfqplbwn,chzugihajytomrdkgsxfqplawn,cvzueihajytomrdkgsxfhpmbwy,cvzueihacytodxdkgsxfqplbwn,cvzurihajytourdkgsdfqplbwn,cvzzeihmjytomrddgsxfqplbwn,cvzucyhajygomrdkgsxfqplbwn,ckzueihzjytomrdkgsxwqplbwn,cvlueihajmtozrdkgsxfqplbwn,cvzkeihajytomrdkgsxfqclbwc,cvzueihajytomrdkgsxgdplbwa,cvzueihyjytoxrdkgcxfqplbwn,cvzueizavytomfdkgsxfqplbwn,cvzueihajwtosrdkgsxfqllbwn,cvzueihajytomrdaksxfqpllwn,cvzuuihojytombdkgsxfqplbwn,cvzuiibajytpmrdkgsxfqplbwn,cvzueihajyuomydkgsxfqplzwn,cvzueihajytimrmkgsxfqplfwn,cvzueihajytomrdkgzxfqpljwo";
            //string origInput = "abcdef,bababc,abbcde,abcccd,aabcdd,abcdee,ababab";
            string[] input = origInput.Split(',');
            int doubles = 0, triples = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var distinctItems = new HashSet<char>();
                foreach (var item in input[i])
                {
                    distinctItems.Add(item);
                }
                var count = new HashSet<int>();
                foreach (var character in distinctItems)
                {
                    switch (input[i].Count(x => x == character))
                    {
                        case 2:
                            count.Add(2);
                            break;
                        case 3:
                            count.Add(3);
                            break;
                        default:
                            break;
                    }

                }
                if (count.Contains(2))
                    doubles++;
                if (count.Contains(3))
                    triples++;
            }
            Console.WriteLine(doubles * triples);
            Console.ReadKey();
        }
        public void Day2Task2()
        {
            string origInput = "cvfueihajytpmrdkgsxfqplbxn,cbzueihajytnmrdkgtxfqplbwn,cvzucihajytomrdkgstfqplqwn,cvzueilajytomrdkgsxfqwnbwn,cvzueihajytomrdkgsgwqphbwn,wuzuerhajytomrdkgsxfqplbwn,cyzueifajybomrdkgsxfqplbwn,cvzueihajxtomrdkgpxfqplmwn,ivzfevhajytomrdkgsxfqplbwn,cvzueihajytomrdlgsxfqphbbn,uvzueihajjtomrdkgsxfqpobwn,cvzupihajytomrdkgsxfqplpwe,cvzueihajyvomrdkgsxfqplbrl,cczueihajytomrdkgsnfqpxbwn,cvzueigajytdmrdkgsxyqplbwn,cvzujihljytomrdkgsxuqplbwn,cvzueisajytomrddgsxkqplbwn,cvzneihajytomrdkgsgaqplbwn,cvzueihajytomrdkgsinmplbwn,cveueihajyromrdkgsxfqplown,cypueihajytotrdkgzxfqplbwn,cvzuoihajytomvdqgsxfqplbwn,cvzuekhejytwmrdkgsxfqplbwn,cvzseihajytomrdkgsxfqgmbwn,cvfuhihajytomrdkgsxfqplbwi,cvzueihujxtomrdkgsufqplbwn,cvzueihdjytomrdogsxfqplbwh,cvzueihdjyfohrdkgsxfqplbwn,cvtudihajytolrdkgsxfqplbwn,cvzueihajytymrdkgshzqplbwn,cvzuebhajytomxdkgsxfqplbwt,cvzulihajyxomrdkgsbfqplbwn,cvzueihajywomrdkgsxfqplbts,cvzueihajytouodkdsxfqplbwn,cvzueihajytomgdkgqxfqklbwn,cvzubihajytomvdkgsxfqplmwn,cvhueihajyyocrdkgsxfqplbwn,zvzueihajytourdkgsxflplbwn,cvzbeihajytomadkgsxfoplbwn,cvzueihajytomrdkgnxfqplbsl,cvfueihajftkmrdkgsxfqplbwn,cvzuexhajytomryugsxfqplbwn,cvzueihajytomsckgsxfqalbwn,cvzuexhajytomrdkbsxfqpluwn,cvzueihajytbmrtkgsxwqplbwn,cvzueihajytomrdigsxfqqlbsn,cvzweihajytomydkgsxfmplbwn,bvzteihajytimrdkgsxfqplbwn,cvzueihajytpmrdkgsxfcpbbwn,cvzueigsjltomrdkgsxfqplbwn,cvzueihajytomrikgsxfopldwn,cvzueihajstomrdkgsxfqplgon,cvzueimajytomrnkxsxfqplbwn,cvzleihagatomrdkgsxfqplbwn,cvbueihajotomrdkgsxfqjlbwn,cvzueihajytomrdkgsxfqppnvn,hvzueihajytomrdkghxfkplbwn,cvzueigajytxmrdkgsxfqplbjn,cvzueihaaxtokrdkgsxfqplbwn,cvzueihajyeomrdkgujfqplbwn,cvzueiwajpoomrdkgsxfqplbwn,cvzieidtjytomrdkgsxfqplbwn,cvzueihalytomrakbsxfqplbwn,wtzueihajytomrdkgsxfqplbwq,cvzuelhaiytomrdkgsxfqplcwn,cvzueihajytomrdkgsxfqslswd,cvzueihajytomrykgssfqplbon,cvzueihfjytovrdegsxfqplbwn,cvzueihajytomldqgsxfqplbwy,cvzleihjjytomrtkgsxfqplbwn,cvzueihaldtomrdtgsxfqplbwn,cvzueihajytzmrdkgsxfeplqwn,cvzueihrjytomddkgsxfqpgbwn,cyzulihajytokrdkgsxfqplbwn,cvsueihajytoordfgsxfqplbwn,fvzueyhajytomrdkgaxfqplbwn,cczueihajytobrdkgsefqplbwn,cvzueihajytomcdrgscfqplbwn,cvzuexhajyvomrdkgssfqplbwn,cvzsmihajyiomrdkgsxfqplbwn,cvzzeihajttomrdkgsxzqplbwn,cvzseihajytomrdkgsxfqpebvn,cvzueihajgthmrdkgsbfqplbwn,ruzueihajytomrdkgsxfqphbwn,cvzueihajytofrdkgsnfrplbwn,cvzuetdajytojrdkgsxfqplbwn,fvzueihajytomrdkghxfqpobwn,cvzueihsjytomrdkgsxfqglbxn,cvzueihajytowrdkgsxfqpsbun,cvzteihaiytomrdkfsxfqplbwn,cvzueihajytkmrdkrsxfqplvwn,cvzueihajyoomrdkasxfqjlbwn,lvzurihajytkmrdkgsxfqplbwn,cvzueihajyyomrdagsxfqelbwn,cvfueihajytomrdkgsxfqplbbx,cvwueihajytommdkgkxfqplbwn,cvzucicajytomrdkgsxcqplbwn,dvzueihahytgmrdkgsxfqplbwn,cvzuechajytomrdkgsxfqelwwn,cvzuekhajytomrdkgsxknplbwn,cvtueihajytomphkgsxfqplbwn,cvzueihabytnzrdkgsxfqplbwn,cvzusihajytomrdkgfxfqplban,cvfueihajytomcdfgsxfqplbwn,mvzueihapytomrdkgsxfdplbwn,cvzueihajytomhdkgsxmqppbwn,jvsueihajytomrdkgsxfqplbln,cvzujihajybomrdkgsxtqplbwn,cvzuekhawytomrdkgsxfqplbwc,svzueihanytomrdogsxfqplbwn,cvzujihajytodrdkgslfqplbwn,cvgdeihajytorrdkgsxfqplbwn,cvzbeihajytoprdkgsxfqplbyn,cvzueihkyytomjdkgsxfqplbwn,cvzuelhojytomrdkgsxfqjlbwn,evzueihajytimrdkgsxfqpsbwn,cvzueihajydomrdkjsxfqplbjn,ovzteihajytosrdkgsxfqplbwn,cvzueihajyaomrdzgsxfqplbgn,cvzuewhajmtomrdkgsufqplbwn,cvzueihajqtomhukgsxfqplbwn,cvzueihajytomzqkgsxfqplbwk,cazuewhakytomrdkgsxfqplbwn,clzueihatytomrdkgzxfqplbwn,dvzueihajytomqdkgsxfqpnbwn,cvzueidajdtomrdkgsxtqplbwn,cvzueihabytowrdkgsxoqplbwn,cvzujihwjytomrdkgsxeqplbwn,cvtuedhajytomrdkgsxfqplbbn,cvzueihajcgomrdkgsxfqplswn,cvzuephajyiomrdngsxfqplbwn,cvzueihajythmqdkgsxfqplbwf,cvzueitajytomrdkgsxfepvbwn,cvzueihajytomydkgsxfqplvwb,dvzueshajytomrddgsxfqplbwn,cvzueihajytomrdkgvxfqpwben,cvzueihajytomrdkgvxfpplwwn,cvzuefhajftomrdkgsxfqrlbwn,cvzueihajytpmrvkgsxfqplbcn,cvzueihajytohrdkgsxfqxnbwn,cvzueihajytomrdposxfqulbwn,cozueihajytomrpkgsxfqrlbwn,cvzuuihaxytomrdkgsxfqplbtn,cvzueihajytomrbzgsxyqplbwn,cveueihajyxoqrdkgsxfqplbwn,cvzueihajytomrkkgsxfqptbrn,cvzuezhajatomrdkssxfqplbwn,cpzueihajytomrdkgsxfhplbwo,lviueihajytomrekgsxfqplbwn,cvzueihwjytomrdkusxfyplbwn,cvzgeihajytomwdkgsxfrplbwn,cvzsejhzjytomrdkgsxfqplbwn,cvzuuihajytomrdkgsxfqdlbwz,cvzjeihajytomrdugsxftplbwn,cvzueihaxytomrrkgsxfmplbwn,cvzueihajgtomrdhgsxfqplwwn,cvzulihajytomedkgsxfqplewn,cvzueivajytomrdkmsxfqplbwc,cvzuervajytomrdkgsxfwplbwn,cvzuemhcjytomrdkgslfqplbwn,cvzyerhauytomrdkgsxfqplbwn,cvzueihaoytomrdkgsyfqplewn,cvzueihanytomrdkgsafkplbwn,cvzueihajvtomrdugsxfqpcbwn,chzueihajytamrdxgsxfqplbwn,cvzueihalytomrdsgsxfqplbln,cvzueihajytoyaykgsxfqplbwn,tlzueihajyeomrdkgsxfqplbwn,cvpueihajytbmrdkgsxfxplbwn,cvzueihajytomjdkgsxuqplkwn,cvzueihajygomrdkgkxfqplbwg,cvzueihajhtomrdkgbxsqplbwn,cvzurihajytomrdkgsafqplbwx,cdzuezhajytomrdkgsxrqplbwn,cvbueihajytotrwkgsxfqplbwn,cwzkeihajytomrdkgsxfqplbwh,cvzheihajytolrikgsxfqplbwn,cozuevhajytomrdkgkxfqplbwn,chzueihajytomrjkgsxfqulbwn,cvzueihkjyromrdkgsxvqplbwn,cvzveihajytomrdkgsxpqplnwn,cvzueihajytoirdkgsxfqihbwn,cvoueihajytomrdkgsxfqpdawn,pvzueihajytomrdkgnxfqplbfn,cvzueihakytomxdkgssfqplbwn,cvzueivajytomrdbgsxaqplbwn,cvzueihajytokrdkgszrqplbwn,cvzuevhajytomrdkgsxgqplbwi,cvzueihajylomrdkgsxflplbpn,hvzueihajytomvdkgsxfqplgwn,cvzleihajytymrrkgsxfqplbwn,crzueieajytomrdkgsxfqplbon,cszueihajytomrdlgqxfqplbwn,cvzueihacytomrdkgsxfjblbwn,cvzreihajytomrdkgsxfqplzun,cvzurihajytomrdkgsxiqplawn,uvzueihajyhovrdkgsxfqplbwn,cvzueihajyqodrdkgssfqplbwn,cvzwiihrjytomrdkgsxfqplbwn,cqzueihajytomrdkgjxfqplban,cvmueihajytoordkgsxfqplbyn,cypueihajytomrdkgzxfqplbwn,cvzueihajykomrdkgsmfqplbtn,cvzueidajytimrdkgsxfqpdbwn,cvzheihajytomrdkgsxfqpfewn,dvzueihajytumrdzgsxfqplbwn,cvzueixajytomrdkgsvfqplgwn,cvzuevhzjyzomrdkgsxfqplbwn,cvyeeihajytomrdkgsxnqplbwn,cvzueihajytomrdkggtpqplbwn,cvzceiyajytomrdkgexfqplbwn,cvzuelhajyyomrdkzsxfqplbwn,cvzhzihajygomrdkgsxfqplbwn,cvzueihwjytomrdkgsgfqplbrn,cvzsevhajytomrdkgqxfqplbwn,cvzueiuajytomrdkgsxfppebwn,nvzueihajytemrdkgsxwqplbwn,cvzueihajytocgdkgsxfqvlbwn,cczusihajytomrdkgsxfqplbpn,cmzueihajytomrdkbsxwqplbwn,cvzumfdajytomrdkgsxfqplbwn,cvzueihcjytomrdkgsxfqplbkl,cvzueihajytomawknsxfqplbwn,kvzueihijytomrdkgsxdqplbwn,cdzutihajytomrdkgsxfkplbwn,cvzufihadylomrdkgsxfqplbwn,cvzueihajytomrgkxsxfqphbwn,cvzuewhajyzomrdkgsxfqelbwn,cvzueihajytomrdkgqxfqelbwc,cvzueshajyoomrdkgsxfqflbwn,cvzueihajyromrekgixfqplbwn,chzugihajytomrdkgsxfqplawn,cvzueihajytomrdkgsxfhpmbwy,cvzueihacytodxdkgsxfqplbwn,cvzurihajytourdkgsdfqplbwn,cvzzeihmjytomrddgsxfqplbwn,cvzucyhajygomrdkgsxfqplbwn,ckzueihzjytomrdkgsxwqplbwn,cvlueihajmtozrdkgsxfqplbwn,cvzkeihajytomrdkgsxfqclbwc,cvzueihajytomrdkgsxgdplbwa,cvzueihyjytoxrdkgcxfqplbwn,cvzueizavytomfdkgsxfqplbwn,cvzueihajwtosrdkgsxfqllbwn,cvzueihajytomrdaksxfqpllwn,cvzuuihojytombdkgsxfqplbwn,cvzuiibajytpmrdkgsxfqplbwn,cvzueihajyuomydkgsxfqplzwn,cvzueihajytimrmkgsxfqplfwn,cvzueihajytomrdkgzxfqpljwo";
            //string origInput = "abcde,fghij,klmno,pqrst,fguij,axcye,wvxyz";
            string[] input = origInput.Split(',');
            string result = "";
            int count = 0;
            char letter = ' ';

            for (int i = 1; i < input.Length; i++)
            {
                var set1 = input[i];
                for (int j = 0; j < input.Length-1; j++)
                {
                    var set2 = input[j];
                    count = 0;
                    
                    for (var character=0; character < set1.Length; character++)
                    {
                        if (set1[character] != set2[character])
                        {
                            count++;
                            letter = set1[character];
                        }
                    }
                    if (count == 1)
                    {
                       result = set1.Remove(set1.IndexOf(letter), 1);
                    }
                    
                }

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
