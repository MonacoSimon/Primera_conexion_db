using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo11
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listapokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonServer server = new PokemonServer();
            listapokemon = server.listas();
            dgvPokemon.DataSource = listapokemon;
            pbImagen.Load(listapokemon[0].UrlImagen);
            
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.UrlImagen);
        }

        private void cargarimagen (string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbImagen.Load("data:image/png;base64,ivborw0kggoaaaansuheugaaankaaadocamaaabvrrfmaaaahfbmvex///8baqeaaaa9pt01ntwgokcrkzh5+fnawmdkysrg4odt09oymjhuvfrxv1dfruvexl51dxuxfxdsbgxjsulgrkznz2e3t7fu7u4sehjiymkghoafn59ycnislcx/f38fhx+pqand3d0kjcq2njytls3o6oivr6/fxcwcgoly8vkmjixjng37aaajekleqvr4no2d63qrkhcgkzyagg8onvfjzdldzf3f39a0uvsmqkdgzfejz1pjlxklddamcoculjsuljsuljsuljsuljsuljsuljsu1cckblflvm0qoc8ljosqfdvbxwqepsjrj7ghqtfxlgj1bqpfjwbrry2qr6vgedqsb2s4igrt4kfvc/gpcwapfdvdtrkwbu76toebcmdw2rdbvjqh++zbif76f4dbsyipubkrmpftt0g8jl3iu0mcvzsk2ltjfnj6c/yuiwbm31rqefiyuw/v4ge2gssywi8vdgyhrmbv3c8grmz3hbsqgecbejhkvgcebfmpg5gamiimxizdcp9gfdj1c8gh7lvfberrqftmplzuvk+oortb9thk0poid1sgduz/bblupmkjpzeryhudbjz/7p99ns2ihzkyxhzbopsxzgew8aznl2sz/bepwkuwntvr27cqpsgyydawkv1pmzo1b1hkd2s5fbrbc5i+jrltaoadydhihm9ixhjm6ybsqn6sp46nr8ymwknuhzat0f5vajtdtz+ymoffhjn9xj6t8gec15knpa4omoxhzwfmghfzui2aqvgytbcgiqzrmk++60schzitafg6qls1rasv4hzj9lksiis4wuh1yvciyu50soj3/cbl1nyueeh2l438nfpx1n1teud2freub9aea28jcsfl1ngkmz/noml4yfqvvn9/jauz68iiwwyfpa1u/o78bnuro8hgx+qyg5ntyad9tz8imsljp9ovt+rhtyposqn5psvhyazkhxgzfhht05kqbwyvuiqjjwcidlenm1jnpmfsyoc6c+ytpttgsf/xkivuunecu/npcioasev2ageii/2wrmlpsc9nd9kjwz9eadtoedohbrq4wpq2vvd8iza94hbtthrs1cshjwppwk5qthmwna5i1/wyq45jigo1idnq4bsoq3zkyugj6/urno9eqxiyx+6v539bazlh9s9mzn8p2yrx7ikyragussnx6dma3zlmc8x/ymfic4hbef0qdrbz9epgthpck8ltzqqx23lvfgtbhvpcrloygbrcs9m7lkt6fzrazd8/w6rbdiwhkxyzpku4vyw3sspqeulnrjhloiukfjzim6agsjvmngvqvlovt583holmbmn4rfo/ii/olhdulxikbkz8ywyfto0toxnkcidtcqnekd1yxst7x4bg2djjtod6zhqxigmrb9s2+00g2ufpag3c6pzs1ml9iqmfqqkzzhd57fmvhcaujlq0llufh0rmowslcavbqnivvcwpdfoxkdsfu8xgyzhxcumdfr3xv2xcfftvsfwsk09ospadi5+5raqtgqwthu7jzl3sny19he9apuawxuhewdxd7xn+/dag89vmxliljlgh7eyeofsguuoec6gagnlvd3x7gii7namcag3s+ozfdjsdcoiborlqcgmb3uyg9kdirofpuigi0xbgauattuyhrpzpbqyx6k8yvxdi7zi7z5ircubkv+qh0/y1/ysmc4jcjaghv7qznexwyfqlebauow4yamwbqcf5ai+bdsivnrtbkgxgmuij+2tjanngqhskmqqtiyw+jmnpzist1gzcvnnaw8ueuvjqhkfwovfuyo/zguqgyoqcmaengaw+geudhaazqx8rgdgg9u/wpmzygmsxzmsa69t8plepwcvah2to7xccfaxwpbbcsuhlbtkdmf7cbibr6vuxcl1covsltm7i9hrxnkwrc7akn+sy0boi01olurs6txh1ki0rrsmyptm5+knrakamy7xg64ysa/zeq98un+uxofeie3itmric2c9asxpjr4vjfn1pkzk4v8tledpzaswucmzlcudqgdgirwtqnt7+4c3iierov0zgaytnddcuccp1wnj6wkzmblg12ssclpdp1dkehocw2v6rc8zuazhzdmmtyuk7hixay7gxyhmm+ba7jzpoct5iylynm016a8y5e6jn6ezfa6xfy7eqg2rcz9g0wpipsmq35sduo9jptagrrupkg/9unyflga3appbk0rssskekhaklyi/sxk5gvwgiyshg+syrnmavaaljqgdnzx40vepr4sg6ahtza8liogf7hsakrcowfw1seflnyovoysg6bcttkeliogurqxnb1jfysymuqny5gb2np1kpynqgyz1m6womhsabrjcai3xipjddgzez2rcyalctnudufpznlwzfhxga36zmewtbiyezqjmxuyitbwba2rdjp2z6lw5kndb0ztsjolc41uimccvlmiikinx2swdxg02ptvaks/vy9lxpg7xgslzzf0bgoa/sfqsho6nxjovak5i6fnf4ks3byrgodfa4qq3ik/ycynzi0z4rswzgclu7usljlazgyuxtrwlc3mgoqawwkoeyphjjrgf79wauzhjirjtqcosmtcaz9areh89nbvf8kndg0o+adpied3hrspbzmqzkbevfvtzb2m7b01qcg6vbkq7iclz9+rju9/lr5mvpjj/bapzadge3y6wgk+mvjd1kbcoveqcz4vug1qnbmfn4v8k37bybjni7syk9mytyu0mcvztgc3yckxio2kz6w2wegt0mmokjqcmdix7kodiwiny1mjdynuejawpfj7gohnglrhmth/tdxvjaii237i8kkzkskpkskpkskpkskpkskpkskpkskpisri4yy7sxumyqkgx2d+6jayvkcquem9xzp1lmorfc57cg+a37hai4v0mfmt72rft+6ghwcrpy7m4pdtyfxss4yhzck+s9cwnzanfdgdlmswjloc7bpestugmsxi7uiaed9ykhnum3taljarhapmmfn4c1zqhgja0udm9adlkuk+k47mkklulud9cydpzbimnavqenha9a36b3icvz9s/ve7ll6nads//jxchg1l0cjdunmoznajaetpgxh22jugd3cf2dfbjegllar/uhnidnpsdz2l//w69pq+3h5s/d78v2frjp/txzrnjnbhzdj4u6low6rrvx3pg9sahi/r4v9u/7dkr+tnhfh9hfq6uepx+ugpsz5aqulbsk/8e8cvz6d5inohzph+jvaaaaaelftksuqmcc");
            }
        }
    }
}
