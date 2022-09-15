namespace KasperKeySharingNetwork;

public interface ICryptographer
{
	string Encrypt(string data);

	string Decrypt(string data);
}
