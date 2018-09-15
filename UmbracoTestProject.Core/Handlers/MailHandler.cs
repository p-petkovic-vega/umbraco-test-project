namespace UmbracoTestProject.Core.Handlers
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;

    /// <summary>
    /// Provides methods for sending e-mail messages.
    /// </summary>
    public class MailHandler
    {
        #region [Members]
        /// <summary>
        /// The singleton instance.
        /// </summary>
        private static readonly MailHandler _instance = new MailHandler();
        #endregion

        #region [Constructors]
        /// <summary>
        /// Prevents a default instance of the <see cref="MailHandler"/> class from being created.
        /// </summary>
        private MailHandler()
        {
        }
        #endregion

        #region [Public Static Methods]
        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static MailHandler Instance
        {
            get
            {
                return MailHandler._instance;
            }
        }
        #endregion

        #region [Public Methods]
        /// <summary>
        /// Send e-mail message.
        /// </summary>
        /// <param name="subject">Subject of e-mail.</param>
        /// <param name="bodyText">Body text of e-mail.</param>
        /// <param name="emailTo">E-mail address where e-mail will be sent to.</param>
        /// <returns><c>true</c> if e-mail successfully sent; otherwise <c>false</c></returns>
        public bool SendMail(string subject, string bodyText, string emailTo)
        {
            return this.SendMail(subject, bodyText, emailTo, new List<Attachment>());
        }

        public bool SendMail(string subject, string bodyText, string emailTo, List<Attachment> attachments)
        {
            return this.SendMail(subject, bodyText, emailTo, attachments, null, null, null);
        }

        /// <summary>
        /// Send e-mail message.
        /// </summary>
        /// <param name="subject">Subject of e-mail.</param>
        /// <param name="bodyText">Body text of e-mail.</param>
        /// <param name="emailTo">E-mail address where e-mail will be sent to.</param>
        /// <param name="attachments">Collection of e-mail attachemnts.</param>
        /// <returns><c>true</c> if e-mail successfully sent; otherwise <c>false</c></returns>
        public bool SendMail(string subject, string bodyText, string emailTo, List<Attachment> attachments, string fromAddress, string fromDisplayName, string replyTo)
        {
            bool retVal = false;

            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.Subject = subject;
                mailMessage.Body = bodyText;
                mailMessage.IsBodyHtml = true;

                if (!String.IsNullOrEmpty(fromAddress))
                {
                    mailMessage.From = new MailAddress(fromAddress, String.IsNullOrEmpty(fromDisplayName) ? fromAddress : fromDisplayName);
                }

                if (!String.IsNullOrEmpty(replyTo))
                {
                    foreach (var tmpEmail in replyTo.Split(';'))
                    {
                        mailMessage.ReplyToList.Add(new MailAddress(tmpEmail));
                    }
                }

                string[] addresses = emailTo.Split(new char[] { ';' });
                for (int i = 0; i < addresses.Length; i++)
                {
                    MailAddress mailAddress = new MailAddress(addresses[i]);
                    mailMessage.To.Add(mailAddress);
                }

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    //smtpClient.EnableSsl = true;

                    // set attachment
                    if (attachments != null && attachments.Count > 0)
                    {
                        attachments.ForEach(x => mailMessage.Attachments.Add(x));
                    }

                    // send E-mail
                    smtpClient.Send(mailMessage);
                    retVal = true;
                }
            }

            return retVal;
        }

        #endregion
    }
}